using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiller
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();

            Task.Run(() =>
            {
                SetMonitorInState(MonitorState.MonitorStateOff);
            }
            );
        }

        private void SetMonitorInState(MonitorState state)
        {
            SendMessage(0xFFFF, 0x112, 0xF170, (int)state);
        }


    }
}
