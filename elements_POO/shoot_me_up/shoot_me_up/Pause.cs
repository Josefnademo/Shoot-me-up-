using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class Pause : Form
    {
        private playGame playGame1;

        public playGameCy_27 playGameCy_27Instance;
        public Pause()
        {
            InitializeComponent();

        }

        private void Pause_Load(object sender, EventArgs e)
        {

        }

        //Method plays the music when button is pressed and stop it when it's not
        public static void ToggleMusic()
        { 
            if (Form1.musicPlaying)
            {
                Form1.player.Stop(); // Music stops
                Form1.musicPlaying = false;
            }
            else
            {
                Form1.player.PlayLooping(); // Music playing in the loop
                Form1.musicPlaying = true;
            }
        }

        //Button plays music, works with method "ToggleMusic"
        private void button3_Click(object sender, EventArgs e)
         {
         ToggleMusic();
        }

         private void button2_Click(object sender, EventArgs e)
         {
             //Continue the game
             this.Close();
         }

         private void button1_Click(object sender, EventArgs e)
         {
             // Create an instance of the second form and show it
             Form1 Menu = new Form1();
             Menu.Show();

            // Loop through all open forms
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // We get the form from the list of open ones
                var openForm = Application.OpenForms[i];

                // We check if the form is not Menu or Pause, then we close it
                if (!(openForm is Form1) && !(openForm is Pause))
                {
                    openForm.Close();
                }
            }
            // close form (Pause)
            this.Close();
         }

         private void button4_Click(object sender, EventArgs e)
         {

         }
    }
}
