﻿//Author: Yosef Nademo
//Date   : 30.09.2024
//Place  : ETML
//Descr. : Options menu of game "SHOOT ME UP!", with buttons:+Sound,-Sonud,Label of Sound options and logo of Options menu. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace shoot_me_up
{
    public partial class Options : Form
    {
       
        // Переменная для хранения уровня громкости
        int SystemSound = 50; // Начальный уровень громкости (от 0 до 100)

        public Options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create an instance of the second form
            Form1 Menu = new Form1();

            // Show the second form
            Menu.Show();

            // Close the first form (optional, if new)
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SystemSound > 10 && SystemSound <= 100)
            {
                SystemSound += 10;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SystemSound >= 0 && SystemSound < 100)
            {
                SystemSound -= 10;
            }
        }

        //stop and turn on music, use methode of class Pause
        private void button4_Click(object sender, EventArgs e)
        {
            Pause.ToggleMusic(); Form1.musicPlaying = false;
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }
        private void button_score_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}