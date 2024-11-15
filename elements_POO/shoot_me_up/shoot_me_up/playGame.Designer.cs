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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playGame));
            this.HP3 = new System.Windows.Forms.PictureBox();
            this.HP2 = new System.Windows.Forms.PictureBox();
            this.HP1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SpaceshipTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // HP3
            // 
            this.HP3.BackColor = System.Drawing.Color.Transparent;
            this.HP3.Image = ((System.Drawing.Image)(resources.GetObject("HP3.Image")));
            this.HP3.Location = new System.Drawing.Point(1, 2);
            this.HP3.Name = "HP3";
            this.HP3.Size = new System.Drawing.Size(61, 80);
            this.HP3.TabIndex = 0;
            this.HP3.TabStop = false;
            this.HP3.Click += new System.EventHandler(this.HP_Click_2);
            // 
            // HP2
            // 
            this.HP2.BackColor = System.Drawing.Color.Transparent;
            this.HP2.Image = ((System.Drawing.Image)(resources.GetObject("HP2.Image")));
            this.HP2.Location = new System.Drawing.Point(56, 2);
            this.HP2.Name = "HP2";
            this.HP2.Size = new System.Drawing.Size(61, 80);
            this.HP2.TabIndex = 1;
            this.HP2.TabStop = false;
            this.HP2.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // HP1
            // 
            this.HP1.BackColor = System.Drawing.Color.Transparent;
            this.HP1.Image = ((System.Drawing.Image)(resources.GetObject("HP1.Image")));
            this.HP1.Location = new System.Drawing.Point(112, 2);
            this.HP1.Name = "HP1";
            this.HP1.Size = new System.Drawing.Size(61, 80);
            this.HP1.TabIndex = 2;
            this.HP1.TabStop = false;
            this.HP1.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShip.Image")));
            this.pictureBoxShip.Location = new System.Drawing.Point(678, 668);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(34, 92);
            this.pictureBoxShip.TabIndex = 3;
            this.pictureBoxShip.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1;
            // 
            // SpaceshipTimer
            // 
            this.SpaceshipTimer.Enabled = true;
            this.SpaceshipTimer.Interval = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label2.Location = new System.Drawing.Point(21, 736);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "click Esc to pause the game";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // pictureBox4_1
            // 
            this.pictureBox4_1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4_1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4_1.Image")));
            this.pictureBox4_1.Location = new System.Drawing.Point(1295, 68);
            this.pictureBox4_1.Name = "pictureBox4_1";
            this.pictureBox4_1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox4_1.TabIndex = 8;
            this.pictureBox4_1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(117, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 80);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(61, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 80);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(6, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 80);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(355, 584);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(156, 87);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(614, 584);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(156, 87);
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.Location = new System.Drawing.Point(889, 584);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(156, 87);
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // playGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1372, 771);
            this.Controls.Add(this.HP1);
            this.Controls.Add(this.HP2);
            this.Controls.Add(this.HP3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxShip);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox9);
            this.Name = "playGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "playGame";
            this.Load += new System.EventHandler(this.playGame_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.HP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        public PictureBox HP3;
        public PictureBox HP2;
        internal PictureBox HP1;
    }
}