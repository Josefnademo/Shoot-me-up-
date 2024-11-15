namespace shoot_me_up
{
    partial class playGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playGame));
            HP3 = new PictureBox();
            HP2 = new PictureBox();
            HP1 = new PictureBox();
            pictureBoxShip = new PictureBox();
            label1 = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            SpaceshipTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox4_1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HP3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HP2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HP1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // HP3
            // 
            HP3.BackColor = Color.Transparent;
            HP3.Image = (Image)resources.GetObject("HP3.Image");
            HP3.Location = new Point(0, -1);
            HP3.Name = "HP3";
            HP3.Size = new Size(61, 80);
            HP3.TabIndex = 0;
            HP3.TabStop = false;
            HP3.Click += HP3_Click;
            // 
            // HP2
            // 
            HP2.BackColor = Color.Transparent;
            HP2.Image = (Image)resources.GetObject("HP2.Image");
            HP2.Location = new Point(62, -1);
            HP2.Name = "HP2";
            HP2.Size = new Size(61, 80);
            HP2.TabIndex = 1;
            HP2.TabStop = false;
            HP2.Click += HP2_Click;
            // 
            // HP1
            // 
            HP1.BackColor = Color.Transparent;
            HP1.Image = (Image)resources.GetObject("HP1.Image");
            HP1.Location = new Point(118, -1);
            HP1.Name = "HP1";
            HP1.Size = new Size(61, 80);
            HP1.TabIndex = 2;
            HP1.TabStop = false;
            HP1.Click += HP1_Click;
            // 
            // pictureBoxShip
            // 
            pictureBoxShip.BackColor = Color.Transparent;
            pictureBoxShip.Image = (Image)resources.GetObject("pictureBoxShip.Image");
            pictureBoxShip.Location = new Point(678, 668);
            pictureBoxShip.Name = "pictureBoxShip";
            pictureBoxShip.Size = new Size(34, 92);
            pictureBoxShip.TabIndex = 3;
            pictureBoxShip.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(1114, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 56);
            label1.TabIndex = 4;
            label1.Text = "Score:0";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 1;
            // 
            // SpaceshipTimer
            // 
            SpaceshipTimer.Enabled = true;
            SpaceshipTimer.Interval = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleVioletRed;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label2.Location = new Point(21, 736);
            label2.Name = "label2";
            label2.Size = new Size(141, 16);
            label2.TabIndex = 7;
            label2.Text = "click Esc to pause the game";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            // 
            // pictureBox4_1
            // 
            pictureBox4_1.BackColor = Color.Transparent;
            pictureBox4_1.Image = (Image)resources.GetObject("pictureBox4_1.Image");
            pictureBox4_1.Location = new Point(1295, 68);
            pictureBox4_1.Name = "pictureBox4_1";
            pictureBox4_1.Size = new Size(65, 65);
            pictureBox4_1.TabIndex = 8;
            pictureBox4_1.TabStop = false;
            pictureBox4_1.Click += pictureBox4_1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(355, 584);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(156, 87);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.Location = new Point(614, 584);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(156, 87);
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.Location = new Point(889, 584);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(156, 87);
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // playGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1372, 771);
            Controls.Add(HP1);
            Controls.Add(HP2);
            Controls.Add(HP3);
            Controls.Add(pictureBox4_1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxShip);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox9);
            Name = "playGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "playGame";
            Load += playGame_Load_2;
            ((System.ComponentModel.ISupportInitialize)HP3).EndInit();
            ((System.ComponentModel.ISupportInitialize)HP2).EndInit();
            ((System.ComponentModel.ISupportInitialize)HP1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer SpaceshipTimer;
        private Label label2;
        private PictureBox pictureBox4_1;
        public System.Windows.Forms.Timer timer1;
        public PictureBox pictureBoxShip;
        public PictureBox pictureBox7;
        public PictureBox pictureBox8;
        public PictureBox pictureBox9;
        public PictureBox HP3;
        public PictureBox HP2;
        public PictureBox HP1;
    }
}