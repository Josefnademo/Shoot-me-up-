namespace shoot_me_up
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrchid;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Cooper Black", 72F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(459, 89);
            label1.Name = "label1";
            label1.Size = new Size(434, 112);
            label1.TabIndex = 0;
            label1.Text = "Options";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Cooper Black", 48F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowFrame;
            button1.Location = new Point(797, 336);
            button1.Name = "button1";
            button1.Size = new Size(535, 284);
            button1.TabIndex = 1;
            button1.Text = "Back to Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Cooper Black", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(98, 336);
            button2.Name = "button2";
            button2.Size = new Size(307, 131);
            button2.TabIndex = 2;
            button2.Text = "LOW YOUR TONE!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Cooper Black", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.MenuBar;
            button3.Location = new Point(98, 496);
            button3.Name = "button3";
            button3.Size = new Size(307, 131);
            button3.TabIndex = 3;
            button3.Text = "LOUDEEEER!";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(60, 251);
            label2.Name = "label2";
            label2.Size = new Size(384, 55);
            label2.TabIndex = 4;
            label2.Text = "Sound Options";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FloralWhite;
            button4.Location = new Point(426, 417);
            button4.Name = "button4";
            button4.Size = new Size(325, 130);
            button4.TabIndex = 5;
            button4.Text = "Music";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1372, 778);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Options";
            Text = "Options";
            Load += Options_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Button button4;
    }
}