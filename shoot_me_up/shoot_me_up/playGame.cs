//Author: Yosef Nademo
//Date   : 13.09.2024
//Place  : ETML
//Descr. : Deplacement of Spaceship...

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class playGame : Form
    {
        /*int playerSpped = 15;
        int enemySpeed = 5;
        int score = 0;
        int enemyBullTimer = 250;


        PictureBox[] enemyInvadersArray;

        bool shooting;
        bool GmaeOver;
        */


        public playGame()
        {
            InitializeComponent();

            // Defines the form to handle keystrokes
            this.KeyPreview = true;

            // Subscribe/Use to the KeyDown event
            this.KeyDown += new KeyEventHandler(playGame_KeyDown);
        }


        // The method that will be called when the key is pressed
        private void playGame_KeyDown(object sender, KeyEventArgs e)
        {

            // Check if the left arrow or A was pressed
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                //barrier not to pass a gamescreen LEFT
                if (pictureBoxShip.Left >= 50)
                {

                    //Move PictureBox on left(2px)
                    pictureBoxShip.Left -= 50;
                }
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                //barrier not to pass a gamescreen RIGHT
                if (pictureBoxShip.Left <= 1288)
                {
                    //Move PictureBox on right(2px)
                    pictureBoxShip.Left += 110;
                }
            }

            else if (e.KeyCode == Keys.Up)
            {
                //Move PictureBox on center
                pictureBoxShip.Left = 694;
            }

        }

        private void playGame_Load(object sender, EventArgs e)
        {

        }

        private void playGame_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxShip_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        
    }
}
