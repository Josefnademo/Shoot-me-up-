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
            this.button1 = new System.Windows.Forms.Button();
            this.button_score = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Cooper Black", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(453, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 160);
            this.button1.TabIndex = 0;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_score
            // 
            this.button_score.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_score.BackgroundImage")));
            this.button_score.Font = new System.Drawing.Font("Cooper Black", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_score.ForeColor = System.Drawing.Color.MistyRose;
            this.button_score.Location = new System.Drawing.Point(849, 550);
            this.button_score.Name = "button_score";
            this.button_score.Size = new System.Drawing.Size(368, 160);
            this.button_score.TabIndex = 1;
            this.button_score.Text = "SCORE";
            this.button_score.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Cooper Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.MistyRose;
            this.button3.Location = new System.Drawing.Point(71, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(368, 160);
            this.button3.TabIndex = 2;
            this.button3.Text = "OPTIONS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1372, 778);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_score);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.MediumPurple;
            this.Name = "Form1";
            this.Text = "shoot-me-up";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button_score;
        private Button button3;
    }
}