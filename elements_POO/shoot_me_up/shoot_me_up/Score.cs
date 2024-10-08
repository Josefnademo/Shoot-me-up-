using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class Score : Form
    {

        public Score()
        {
            InitializeComponent();

            //Music of score
            Form1.player = new SoundPlayer(Form1.musicList[2]);
            Form1.player.PlayLooping();
        }

        //back to menu button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Form1 Form2 = new Form1();

            // Show the second form
            Form2.Show();

            // Close the first form (optional, if new)
            this.Hide();
        }

        private void Score_Load(object sender, EventArgs e)
        {

        }
    }
}
