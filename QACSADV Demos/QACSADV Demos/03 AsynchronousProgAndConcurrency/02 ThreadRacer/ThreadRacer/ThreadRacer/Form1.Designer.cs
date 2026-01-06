using System.Resources;

namespace ThreadRacer
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
            picBlue = new PictureBox();
            picGreen = new PictureBox();
            picRed = new PictureBox();
            picPurple = new PictureBox();
            picBlack = new PictureBox();
            picFlag = new PictureBox();
            btnGo = new Button();
            pictureBox1 = new PictureBox();
            lblResult = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)picBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPurple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBlack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picBlue
            // 
            picBlue.Image = Properties.Resources.bluecar;
            picBlue.Location = new Point(13, 62);
            picBlue.Name = "picBlue";
            picBlue.Size = new Size(100, 50);
            picBlue.SizeMode = PictureBoxSizeMode.StretchImage;
            picBlue.TabIndex = 0;
            picBlue.TabStop = false;
            // 
            // picGreen
            // 
            picGreen.Image = Properties.Resources.greencar;
            picGreen.Location = new Point(13, 117);
            picGreen.Name = "picGreen";
            picGreen.Size = new Size(100, 50);
            picGreen.SizeMode = PictureBoxSizeMode.StretchImage;
            picGreen.TabIndex = 0;
            picGreen.TabStop = false;
            // 
            // picRed
            // 
            picRed.Image = Properties.Resources.redcar;
            picRed.Location = new Point(13, 175);
            picRed.Name = "picRed";
            picRed.Size = new Size(100, 50);
            picRed.SizeMode = PictureBoxSizeMode.StretchImage;
            picRed.TabIndex = 0;
            picRed.TabStop = false;
            // 
            // picPurple
            // 
            picPurple.Image = Properties.Resources.purplecar;
            picPurple.Location = new Point(13, 233);
            picPurple.Name = "picPurple";
            picPurple.Size = new Size(100, 50);
            picPurple.SizeMode = PictureBoxSizeMode.StretchImage;
            picPurple.TabIndex = 0;
            picPurple.TabStop = false;
            // 
            // picBlack
            // 
            picBlack.Image = Properties.Resources.blackcar;
            picBlack.Location = new Point(13, 290);
            picBlack.Name = "picBlack";
            picBlack.Size = new Size(100, 50);
            picBlack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBlack.TabIndex = 0;
            picBlack.TabStop = false;
            // 
            // picFlag
            // 
            picFlag.Image = Properties.Resources.Flag;
            picFlag.Location = new Point(668, 350);
            picFlag.Name = "picFlag";
            picFlag.Size = new Size(91, 53);
            picFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            picFlag.TabIndex = 1;
            picFlag.TabStop = false;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(9, 351);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(123, 49);
            btnGo.TabIndex = 2;
            btnGo.Text = "Go!";
            btnGo.Click += btnGo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Flag;
            pictureBox1.Location = new Point(668, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(147, 364);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(492, 23);
            lblResult.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(9, 406);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 49);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(btnReset);
            Controls.Add(lblResult);
            Controls.Add(btnGo);
            Controls.Add(picFlag);
            Controls.Add(picBlue);
            Controls.Add(picGreen);
            Controls.Add(picRed);
            Controls.Add(picPurple);
            Controls.Add(picBlack);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form-U-La-1";
            ((System.ComponentModel.ISupportInitialize)picBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPurple).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBlack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox picPurple;
        private System.Windows.Forms.PictureBox picBlack;
        private System.Windows.Forms.PictureBox picFlag;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox picGreen;
        private System.Windows.Forms.PictureBox picRed;
        #endregion

        private Button btnReset;
    }
}
