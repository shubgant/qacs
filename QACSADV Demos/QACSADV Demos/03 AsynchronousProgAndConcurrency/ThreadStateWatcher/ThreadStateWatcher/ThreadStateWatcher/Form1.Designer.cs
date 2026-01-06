namespace ThreadStateWatcher
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 15);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(155, 59);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Thread";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "State:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(104, 169);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(400, 28);
            this.txtState.TabIndex = 7;
            this.txtState.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(179, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 59);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Thread";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(343, 15);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(155, 59);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop Thread";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSuspend
            // 
            this.btnSuspend.Enabled = false;
            this.btnSuspend.Location = new System.Drawing.Point(15, 87);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(155, 59);
            this.btnSuspend.TabIndex = 3;
            this.btnSuspend.Text = "Suspend Thread";
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // btnResume
            // 
            this.btnResume.Enabled = false;
            this.btnResume.Location = new System.Drawing.Point(179, 87);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(155, 59);
            this.btnResume.TabIndex = 4;
            this.btnResume.Text = "Resume Thread";
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Enabled = false;
            this.btnSleep.Location = new System.Drawing.Point(343, 87);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(155, 59);
            this.btnSleep.TabIndex = 5;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // Form1
            // 
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtState,
                this.label1,
                this.btnCreate,
                this.btnStart,
                this.btnStop,
                this.btnSuspend,
                this.btnResume,
                this.btnSleep});
            this.Text = "ThreadStateWatcher";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnSleep;
        #endregion
    }
}
