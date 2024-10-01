namespace shoot_me_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button_score = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Cooper Black", 55F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(496, 366);
            button1.Name = "button1";
            button1.Size = new Size(377, 160);
            button1.TabIndex = 0;
            button1.Text = "PLAY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_score
            // 
            button_score.BackgroundImage = (Image)resources.GetObject("button_score.BackgroundImage");
            button_score.Font = new Font("Cooper Black", 55F, FontStyle.Regular, GraphicsUnit.Point);
            button_score.ForeColor = Color.MistyRose;
            button_score.Location = new Point(937, 549);
            button_score.Name = "button_score";
            button_score.Size = new Size(368, 160);
            button_score.TabIndex = 1;
            button_score.Text = "SCORE";
            button_score.UseVisualStyleBackColor = true;
            button_score.Click += button_score_Click_1;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Cooper Black", 50F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.MistyRose;
            button3.Location = new Point(71, 550);
            button3.Name = "button3";
            button3.Size = new Size(368, 160);
            button3.TabIndex = 2;
            button3.Text = "OPTIONS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1264, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 87);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cooper Black", 48F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.IndianRed;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(496, 606);
            button2.Name = "button2";
            button2.Size = new Size(377, 160);
            button2.TabIndex = 5;
            button2.Text = "SKINS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1372, 778);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button_score);
            Controls.Add(button1);
            Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.MediumPurple;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "shoot-me-up";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button_score;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button2;
    }
}