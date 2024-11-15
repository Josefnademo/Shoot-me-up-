namespace shoot_me_up
{
    partial class Mars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mars));
            HP1 = new PictureBox();
            HP2 = new PictureBox();
            HP3 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBoxShip = new PictureBox();
            pictureBox4_1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)HP1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HP2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HP3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_1).BeginInit();
            SuspendLayout();
            // 
            // HP1
            // 
            HP1.BackColor = Color.Transparent;
            HP1.Image = (Image)resources.GetObject("HP1.Image");
            HP1.Location = new Point(110, 1);
            HP1.Name = "HP1";
            HP1.Size = new Size(61, 80);
            HP1.TabIndex = 14;
            HP1.TabStop = false;
            HP1.Click += HP1_Click;
            // 
            // HP2
            // 
            HP2.BackColor = Color.Transparent;
            HP2.Image = (Image)resources.GetObject("HP2.Image");
            HP2.Location = new Point(54, 1);
            HP2.Name = "HP2";
            HP2.Size = new Size(61, 80);
            HP2.TabIndex = 13;
            HP2.TabStop = false;
            HP2.Click += HP2_Click;
            // 
            // HP3
            // 
            HP3.BackColor = Color.Transparent;
            HP3.Image = (Image)resources.GetObject("HP3.Image");
            HP3.Location = new Point(-1, 1);
            HP3.Name = "HP3";
            HP3.Size = new Size(61, 80);
            HP3.TabIndex = 12;
            HP3.TabStop = false;
            HP3.Click += HP3_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Location = new Point(4, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 80);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Location = new Point(59, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 80);
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(115, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 80);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBoxShip
            // 
            pictureBoxShip.BackColor = Color.Transparent;
            pictureBoxShip.BackgroundImage = (Image)resources.GetObject("pictureBoxShip.BackgroundImage");
            pictureBoxShip.Location = new Point(688, 645);
            pictureBoxShip.Name = "pictureBoxShip";
            pictureBoxShip.Size = new Size(52, 117);
            pictureBoxShip.TabIndex = 18;
            pictureBoxShip.TabStop = false;
            pictureBoxShip.Click += pictureBoxShip_Click;
            // 
            // pictureBox4_1
            // 
            pictureBox4_1.BackColor = Color.Transparent;
            pictureBox4_1.Image = (Image)resources.GetObject("pictureBox4_1.Image");
            pictureBox4_1.Location = new Point(1295, 68);
            pictureBox4_1.Name = "pictureBox4_1";
            pictureBox4_1.Size = new Size(65, 65);
            pictureBox4_1.TabIndex = 20;
            pictureBox4_1.TabStop = false;
            pictureBox4_1.Click += pictureBox4_1_Click_1;
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
            label1.TabIndex = 19;
            label1.Text = "Score:0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label2.Location = new Point(4, 746);
            label2.Name = "label2";
            label2.Size = new Size(141, 16);
            label2.TabIndex = 21;
            label2.Text = "click Esc to pause the game";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            // 
            // Mars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1372, 771);
            Controls.Add(label2);
            Controls.Add(pictureBox4_1);
            Controls.Add(label1);
            Controls.Add(pictureBoxShip);
            Controls.Add(HP1);
            Controls.Add(HP2);
            Controls.Add(HP3);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Name = "Mars";
            Text = "Mars";
            Load += Mars_Load_1;
            ((System.ComponentModel.ISupportInitialize)HP1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HP2).EndInit();
            ((System.ComponentModel.ISupportInitialize)HP3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox HP1;
        private PictureBox HP2;
        private PictureBox HP3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4_1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        public PictureBox pictureBoxShip;
    }
}