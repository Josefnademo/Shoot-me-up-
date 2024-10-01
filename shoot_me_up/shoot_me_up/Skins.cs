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
    public partial class Skins : Form
    {
        public static bool musicPlaying = true; //variable wich will track the state of music.
        public static SoundPlayer player;
        public Skins()
        {
            InitializeComponent();

            //Music of score
            if (musicPlaying)
            {
                Skins.player = new SoundPlayer(Form1.musicList[3]);
                Skins.player.PlayLooping();
                musicPlaying = false;
            }
            else
            {
                Form1.player = new SoundPlayer(Form1.musicList[3]);
                Form1.player.PlayLooping();
                musicPlaying = true;
            }
        }

        private void Skins_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Form1 Menu = new Form1();

            // Show the second form
            Menu.Show();

            // Close the first form (optional, if new)
            this.Close();
           
        }
    }
}
