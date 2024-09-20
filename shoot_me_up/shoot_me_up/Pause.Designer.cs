namespace shoot_me_up
{
    partial class Pause
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pause));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Cooper Black", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(411, 327);
            button1.Name = "button1";
            button1.Size = new Size(270, 130);
            button1.TabIndex = 0;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Cooper Black", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(401, 171);
            button2.Name = "button2";
            button2.Size = new Size(300, 150);
            button2.TabIndex = 1;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Cooper Black", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(411, 463);
            button3.Name = "button3";
            button3.Size = new Size(270, 130);
            button3.TabIndex = 2;
            button3.Text = "Music (0w0)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Pause
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1142, 636);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Pause";
            Text = "Pause";
            Load += Pause_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}