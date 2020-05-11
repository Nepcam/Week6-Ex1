namespace PracTest2
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.buttonDrawPhone = new System.Windows.Forms.Button();
            this.buttonDrawBalls = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxNumLottoBalls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(285, 7);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(400, 730);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // buttonDrawPhone
            // 
            this.buttonDrawPhone.Location = new System.Drawing.Point(21, 12);
            this.buttonDrawPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawPhone.Name = "buttonDrawPhone";
            this.buttonDrawPhone.Size = new System.Drawing.Size(112, 30);
            this.buttonDrawPhone.TabIndex = 1;
            this.buttonDrawPhone.Text = "Draw Phone";
            this.buttonDrawPhone.UseVisualStyleBackColor = true;
            this.buttonDrawPhone.Click += new System.EventHandler(this.buttonDrawPhone_Click);
            // 
            // buttonDrawBalls
            // 
            this.buttonDrawBalls.Location = new System.Drawing.Point(157, 12);
            this.buttonDrawBalls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrawBalls.Name = "buttonDrawBalls";
            this.buttonDrawBalls.Size = new System.Drawing.Size(112, 30);
            this.buttonDrawBalls.TabIndex = 2;
            this.buttonDrawBalls.Text = "Draw Balls";
            this.buttonDrawBalls.UseVisualStyleBackColor = true;
            this.buttonDrawBalls.Click += new System.EventHandler(this.buttonDrawBalls_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(21, 141);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 30);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(157, 141);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 30);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxNumLottoBalls
            // 
            this.textBoxNumLottoBalls.Location = new System.Drawing.Point(133, 81);
            this.textBoxNumLottoBalls.Name = "textBoxNumLottoBalls";
            this.textBoxNumLottoBalls.Size = new System.Drawing.Size(136, 20);
            this.textBoxNumLottoBalls.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter number of balls:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(691, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumLottoBalls);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDrawBalls);
            this.Controls.Add(this.buttonDrawPhone);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "COMP103 Practical Test 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button buttonDrawPhone;
        private System.Windows.Forms.Button buttonDrawBalls;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxNumLottoBalls;
        private System.Windows.Forms.Label label1;
    }
}

