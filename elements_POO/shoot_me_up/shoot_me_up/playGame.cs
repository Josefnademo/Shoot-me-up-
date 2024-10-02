﻿//Author: Yosef Nademo
//Date   : 30.09.2024
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

        private System.Windows.Forms.Timer movementTimer;


        public playGame()
        {
            InitializeComponent();

            // Подготавливаем таймер для плавного перемещения
            movementTimer = new System.Windows.Forms.Timer();
            movementTimer.Interval = 2; // Интервал срабатывания таймера (2 мс)
            movementTimer.Tick += MovementTimer_Tick; // Привязываем метод, который будет вызываться при каждом тике таймера
            movementTimer.Start(); // Запускаем таймер



            // Defines the form to handle keystrokes
            this.KeyPreview = true;

            // Subscribe/Use to the KeyDown event
            this.KeyDown += new KeyEventHandler(playGame_KeyDown);

        }

        // Метод, который будет вызываться при каждом тике таймера (каждые 20 мс)
        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            if (goLeft && pictureBoxShip.Left > 0)
            {
                pictureBoxShip.Left -= playerSpeed;
            }
            if (goRight && pictureBoxShip.Right < this.ClientSize.Width)
            {
                pictureBoxShip.Left += playerSpeed;
            }
        }


        // The method that will be called when some key is pressed
        private void playGame_KeyDown(object sender, KeyEventArgs e)
        {

            // Check if the "left arrow" or "A" was pressed
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goRight = true;

            }

            if (e.KeyCode == Keys.Up)
            {
                //Move PictureBox on center
                pictureBoxShip.Left = 694;
            }

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


        private void label2_Click_1(object sender, EventArgs e)
        {
            if (timer1 == default)
            {
                label2.Hide();
            }
        }
        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBoxShip_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void HP_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void playGame_Load(object sender, EventArgs e)
        {

        }
    }
}