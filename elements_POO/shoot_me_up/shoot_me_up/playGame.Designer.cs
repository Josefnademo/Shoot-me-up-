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
            pictureBox3 = new PictureBox();
            SpaceshipTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            HP.Click += HP_Click;
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
            pictureBox1.Click += pictureBox1_Click_1;
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
            pictureBox2.Click += pictureBox2_Click_2;
            // 
            // pictureBoxShip
            // 
            pictureBoxShip.BackColor = Color.Transparent;
            pictureBoxShip.Image = (Image)resources.GetObject("pictureBoxShip.Image");
            pictureBoxShip.Location = new Point(678, 638);
            pictureBoxShip.Name = "pictureBoxShip";
            pictureBoxShip.Size = new Size(34, 90);
            pictureBoxShip.TabIndex = 3;
            pictureBoxShip.TabStop = false;
            pictureBoxShip.Click += pictureBoxShip_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(1167, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 56);
            label1.TabIndex = 4;
            label1.Text = "Score:0";
            // 
            // GameTimer
            // 
            GameTimer.Interval = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(287, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 84);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // SpaceshipTimer
            // 
            SpaceshipTimer.Interval = 2;
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
            label2.Click += label2_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1295, 68);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 65);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // playGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1372, 778);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBoxShip);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(HP);
            Name = "playGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "playGame";
            Load += playGame_Load;
            ((System.ComponentModel.ISupportInitialize)HP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox HP;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxShip;
        private Label label1;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer SpaceshipTimer;
        private Label label2;
        private PictureBox pictureBox4;
        public System.Windows.Forms.Timer timer1;
    }
}