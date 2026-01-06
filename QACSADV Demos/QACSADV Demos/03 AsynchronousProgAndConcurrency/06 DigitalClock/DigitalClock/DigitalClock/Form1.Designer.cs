namespace DigitalClock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Black;
            this.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClock.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Lime;
            this.lblClock.Location = new System.Drawing.Point(0, 2);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(348, 64);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSleep
            // 
            this.btnSleep.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.btnSleep.Location = new System.Drawing.Point(7, 75);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(93, 49);
            this.btnSleep.TabIndex = 1;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnThread
            // 
            this.btnThread.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.btnThread.Location = new System.Drawing.Point(106, 75);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(169, 49);
            this.btnThread.TabIndex = 1;
            this.btnThread.Text = "DeadLock!";
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);



            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnThread);
            this.Text = "QA Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSleep;
        #endregion
    }
}
