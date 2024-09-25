//Author: Yosef Nademo
//Date   : 13.09.2024
//Place  : ETML
//Descr. : Deplacement of Spaceship...

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class playGame : Form
    {
        private Pause PauseMenu;

        bool goLeft, goRight;
        int playerSpeed = 15;
        public int hp = 3;
        int enemySpeed = 5;
        int score = 0;
        int enemyBullTimer = 250;

        PictureBox[] enemyArray;

        bool shooting;
        bool GameOver;


        public playGame()
        {
            InitializeComponent();

            // Defines the form to handle keystrokes
            this.KeyPreview = true;

            // Subscribe/Use to the KeyDown event
            this.KeyDown += new KeyEventHandler(playGame_KeyDown);

        }

        // The method that will be called when some key is pressed
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

            if (e.KeyCode == Keys.Up)
            {
                //Move PictureBox on center
                pictureBoxShip.Left = 694;
            }

            /*
                        if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                        {
                            goLeft = true;
                        }
                        if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                        {
                            goRight = true;
                        }*/

            // shoot with bullet 
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

            }

            if (e.KeyCode == Keys.Escape)
            {
                if (PauseMenu == null)
                {
                    // Create an instance of the second form
                    PauseMenu = new Pause();

                    // Subscribe to the FormClosed event to reset PauseMenu when it's closed //assigning the PauseMenu variable a null value.
                    PauseMenu.FormClosed += (s, args) => PauseMenu = null;

                    // Show the second form
                    PauseMenu.Show();
                }
                else
                {
                    PauseMenu.Close();
                }
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

            if (PauseMenu == null)
            {
                // Create a new instance of the PauseMenu form
                PauseMenu = new Pause();

                // Subscribe to the FormClosed event to reset PauseMenu when it's closed //assigning the PauseMenu variable a null value.
                PauseMenu.FormClosed += (s, args) => PauseMenu = null;    

                // Show the PauseMenu form
                PauseMenu.Show();
            }
            else
            {
                PauseMenu.Close();
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 0)
            {
                label2.Hide();
            }
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Проверяем, если таймер равен 0 (то есть время истекло)
            if (timer1.Interval == 0)
            {
                // Скрываем метку (Label)
                label2.Hide();
            }
        }

       

        
    }
}
