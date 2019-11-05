namespace ChillerNF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.upDownHours = new System.Windows.Forms.NumericUpDown();
            this.upDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.upDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "minutes";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(9, 95);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(288, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "seconds";
            // 
            // upDownHours
            // 
            this.upDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upDownHours.Location = new System.Drawing.Point(9, 21);
            this.upDownHours.Name = "upDownHours";
            this.upDownHours.Size = new System.Drawing.Size(92, 68);
            this.upDownHours.TabIndex = 7;
            this.upDownHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upDownMinutes
            // 
            this.upDownMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upDownMinutes.Location = new System.Drawing.Point(110, 21);
            this.upDownMinutes.Name = "upDownMinutes";
            this.upDownMinutes.Size = new System.Drawing.Size(92, 68);
            this.upDownMinutes.TabIndex = 8;
            this.upDownMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upDownMinutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // upDownSeconds
            // 
            this.upDownSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upDownSeconds.Location = new System.Drawing.Point(208, 21);
            this.upDownSeconds.Name = "upDownSeconds";
            this.upDownSeconds.Size = new System.Drawing.Size(92, 68);
            this.upDownSeconds.TabIndex = 9;
            this.upDownSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enable SCROLL LOCK to keep monitors off.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 244);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upDownSeconds);
            this.Controls.Add(this.upDownMinutes);
            this.Controls.Add(this.upDownHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chiller";
            ((System.ComponentModel.ISupportInitialize)(this.upDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upDownHours;
        private System.Windows.Forms.NumericUpDown upDownMinutes;
        private System.Windows.Forms.NumericUpDown upDownSeconds;
        private System.Windows.Forms.Label label4;
    }
}

