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
            HP = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBoxShip = new PictureBox();
            label1 = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            SpaceshipTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox4_1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // HP
            // 
            HP.BackColor = Color.Transparent;
            HP.Image = (Image)resources.GetObject("HP.Image");
            HP.Location = new Point(1, 2);
            HP.Name = "HP";
            HP.Size = new Size(61, 80);
            HP.TabIndex = 0;
            HP.TabStop = false;
            HP.Click += HP_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 80);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(112, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 80);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            label1.Click += label1_Click;
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
            pictureBox4_1.Click += pictureBox4_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(117, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 80);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(61, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 80);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Location = new Point(6, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 80);
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
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
            pictureBox7.Click += pictureBox7_Click;
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
            pictureBox8.Click += pictureBox8_Click;
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
            pictureBox9.Click += pictureBox9_Click;
            // 
            // playGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1372, 771);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(HP);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
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
            Load += playGame_Load_1;
            ((System.ComponentModel.ISupportInitialize)HP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        public PictureBox pictureBox7;
        public PictureBox pictureBox8;
        public PictureBox pictureBox9;
        public PictureBox HP;
        public PictureBox pictureBox1;
        internal PictureBox pictureBox2;
    }
}