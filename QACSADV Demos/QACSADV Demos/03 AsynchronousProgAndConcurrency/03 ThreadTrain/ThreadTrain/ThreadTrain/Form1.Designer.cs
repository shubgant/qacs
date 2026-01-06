namespace ThreadTrain
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
            picRT1 = new PictureBox();
            picRT2 = new PictureBox();
            picRT3 = new PictureBox();
            picLT1 = new PictureBox();
            picLT2 = new PictureBox();
            btnGo = new Button();
            picLT3 = new PictureBox();
            btnStop = new Button();
            lblSingleLeft = new Label();
            lblSingleRight = new Label();
            ((System.ComponentModel.ISupportInitialize)picRT1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRT2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRT3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLT1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLT2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLT3).BeginInit();
            SuspendLayout();
            // 
            // picRT1
            // 
            picRT1.Image = Properties.Resources.righttrain;
            picRT1.Location = new Point(7, 2);
            picRT1.Name = "picRT1";
            picRT1.Size = new Size(100, 50);
            picRT1.SizeMode = PictureBoxSizeMode.StretchImage;
            picRT1.TabIndex = 0;
            picRT1.TabStop = false;
            // 
            // picRT2
            // 
            picRT2.Image = Properties.Resources.righttrain;
            picRT2.Location = new Point(7, 57);
            picRT2.Name = "picRT2";
            picRT2.Size = new Size(100, 50);
            picRT2.SizeMode = PictureBoxSizeMode.StretchImage;
            picRT2.TabIndex = 0;
            picRT2.TabStop = false;
            // 
            // picRT3
            // 
            picRT3.Image = Properties.Resources.righttrain;
            picRT3.Location = new Point(7, 113);
            picRT3.Name = "picRT3";
            picRT3.Size = new Size(100, 50);
            picRT3.SizeMode = PictureBoxSizeMode.StretchImage;
            picRT3.TabIndex = 0;
            picRT3.TabStop = false;
            // 
            // picLT1
            // 
            picLT1.Image = Properties.Resources.lefttrain;
            picLT1.Location = new Point(660, 180);
            picLT1.Name = "picLT1";
            picLT1.Size = new Size(100, 50);
            picLT1.SizeMode = PictureBoxSizeMode.StretchImage;
            picLT1.TabIndex = 0;
            picLT1.TabStop = false;
            // 
            // picLT2
            // 
            picLT2.Image = Properties.Resources.lefttrain;
            picLT2.Location = new Point(660, 237);
            picLT2.Name = "picLT2";
            picLT2.Size = new Size(100, 50);
            picLT2.SizeMode = PictureBoxSizeMode.StretchImage;
            picLT2.TabIndex = 0;
            picLT2.TabStop = false;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(505, 352);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(123, 49);
            btnGo.TabIndex = 2;
            btnGo.Text = "Start";
            btnGo.Click += btnGo_Click;
            // 
            // picLT3
            // 
            picLT3.Image = Properties.Resources.lefttrain;
            picLT3.Location = new Point(661, 294);
            picLT3.Name = "picLT3";
            picLT3.Size = new Size(100, 50);
            picLT3.SizeMode = PictureBoxSizeMode.StretchImage;
            picLT3.TabIndex = 0;
            picLT3.TabStop = false;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(638, 351);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(123, 49);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.Click += btnStop_Click;
            // 
            // lblSingleLeft
            // 
            lblSingleLeft.BackColor = SystemColors.ControlDarkDark;
            lblSingleLeft.Location = new Point(275, 8);
            lblSingleLeft.Name = "lblSingleLeft";
            lblSingleLeft.Size = new Size(5, 345);
            lblSingleLeft.TabIndex = 3;
            // 
            // lblSingleRight
            // 
            lblSingleRight.BackColor = SystemColors.ControlDarkDark;
            lblSingleRight.Location = new Point(475, 8);
            lblSingleRight.Name = "lblSingleRight";
            lblSingleRight.Size = new Size(5, 345);
            lblSingleRight.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGo);
            Controls.Add(picRT1);
            Controls.Add(picRT2);
            Controls.Add(picRT3);
            Controls.Add(picLT1);
            Controls.Add(picLT2);
            Controls.Add(picLT3);
            Controls.Add(btnStop);
            Controls.Add(lblSingleLeft);
            Controls.Add(lblSingleRight);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "QA Thread Train";
            ((System.ComponentModel.ISupportInitialize)picRT1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRT2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRT3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLT1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLT2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLT3).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox picRT1;
        private System.Windows.Forms.PictureBox picRT2;
        private System.Windows.Forms.PictureBox picRT3;
        private System.Windows.Forms.PictureBox picLT3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblSingleLeft;
        private System.Windows.Forms.Label lblSingleRight;
        private System.Windows.Forms.PictureBox picLT1;
        private System.Windows.Forms.PictureBox picLT2;
        #endregion
    }
}
