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
        public static bool musicPlaying = true; //variable wich will track the state of music.
        private playGame playGame1;

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
            if (musicPlaying)
            {
                Form1.player.Stop(); // Music stops
                musicPlaying = false;
            }
            else
            {
                Form1.player.PlayLooping(); // Music playing in the loop
                musicPlaying = true;
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
             // Create an instance of the second form
             Form1 Menu = new Form1();

             // Show the second form
             Menu.Show();

             // Close the first form (optional, if new)
             this.Close();

            // Close the playGame form (if available). And use for loop to avoid additional opened windows.  ..I had a problem with multiple windows of playGame form,but now idon't,but i want to leav it here just to be sure that's gonna work in anny case :)  
            for (int i = 0; i < Application.OpenForms.Count; i++) { 
             if (Application.OpenForms[i] is playGame playGameInstance)
             {
                playGameInstance.Close();
             }
            }

         }

         private void button4_Click(object sender, EventArgs e)
         {

         }
    }
}
