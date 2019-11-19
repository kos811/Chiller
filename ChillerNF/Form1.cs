using System;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChillerNF
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        private bool _countDownStarted = false;
        private TimeSpan _countDown;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void SetMonitorInState(MonitorState state)
        {
            SendMessage(0xFFFF, 0x112, 0xF170, (int)state);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Control.IsKeyLocked(Keys.Scroll))
            {
                SetMonitorInState(MonitorState.MonitorStateOff);
            }

            if (_countDownStarted)
            {
                _countDown = _countDown.Add(new TimeSpan(0, 0, 0, 0, -100));
                SetUpDowns(_countDown);
                if (_countDown.TotalSeconds == 0)
                {
                    startButton_Click(sender, e);
                    Shutdown();
                }
            }
        }

        private void startButton_Click(object sender, System.EventArgs e)
        {
            if (!_countDownStarted)
            {
                _countDownStarted = true;
                _countDown = ParseUpDowns();
                startButton.Text = "STOP";
                upDownHours.Enabled = false;
                upDownMinutes.Enabled = false;
                upDownSeconds.Enabled = false;
            }
            else
            {
                _countDownStarted = false;
                startButton.Text = "START";
                upDownHours.Enabled = true;
                upDownMinutes.Enabled = true;
                upDownSeconds.Enabled = true;
            }
        }

        private TimeSpan ParseUpDowns()
        {
            var h = (int)upDownHours.Value;
            var m = (int)upDownMinutes.Value;
            var s = (int)upDownSeconds.Value;
            var result = new TimeSpan(h, m, s);
            return result;
        }

        private void SetUpDowns(TimeSpan ts)
        {
            upDownHours.Value = ts.Hours;
            upDownMinutes.Value = ts.Minutes;
            upDownSeconds.Value = ts.Seconds;
        }

        private void Shutdown()
        {
            ManagementBaseObject mboShutdown = null;
            using (var mcWin32 = new ManagementClass("Win32_OperatingSystem"))
            {
                mcWin32.Get();

                // You can't shutdown without security privileges
                mcWin32.Scope.Options.EnablePrivileges = true;
                using (var mboShutdownParams =
                         mcWin32.GetMethodParameters("Win32Shutdown"))
                {

                    // Flag 1 means we want to shut down the system. Use "2" to reboot.
                    mboShutdownParams["Flags"] = "1";
                    mboShutdownParams["Reserved"] = "0";
                    foreach (ManagementObject manObj in mcWin32.GetInstances())
                    {
                        mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                                       mboShutdownParams, null);
                    }
                }
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            var targetState = FormWindowState.Normal;
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    targetState = FormWindowState.Minimized;
                    break;
                case FormWindowState.Minimized:
                    targetState = FormWindowState.Normal;
                    break;
            }
            this.WindowState = targetState;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Show", new EventHandler((object s, EventArgs ea) =>
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }));
            trayMenu.MenuItems.Add("Exit", new EventHandler((object s, EventArgs ea) => Application.Exit()));
            trayIcon = new NotifyIcon();
            trayIcon.Text = "MyTrayApp";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            // Add menu to tray icon and show it.
            //trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            trayIcon.DoubleClick += new EventHandler(this.notifyIcon1_Click);
            trayIcon.Click += new EventHandler(this.notifyIcon1_Click);
            trayIcon.ContextMenu = trayMenu;
        }
    }
}
