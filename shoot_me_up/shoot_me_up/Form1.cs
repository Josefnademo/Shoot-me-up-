//Author: Yosef Nademo
//Date   : 13.09.2024
//Place  : ETML
//Descr. : Main menu of game "SHOOT ME UP!", with buttons:Optioins,Play,Score and logo of game. 

using System.Media;

namespace shoot_me_up
{
    public partial class Form1 : Form
    {
        //music of gameround
        SoundPlayer player = new SoundPlayer(@"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\music\Radiohead-No-Surprises.wav");


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)      //score button
        {

        }

        private void button1_Click(object sender, EventArgs e)      //score play
        {

        }

        private void Form1_Load(object sender, EventArgs e)         //background of manu
        {

        }

        private void button3_Click(object sender, EventArgs e)      //score options
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the second form
            playGame playGame = new playGame();

            // Show the second form
            playGame.Show();

            // Close the first form (optional, if new)
            this.Hide();

            //Start the music when button PLAY is pressed
            player.Play();

            // Subscription to the close event of the playGame form
            playGame.FormClosed += (s, args) =>               //=>: This is part of the lambda expression, which says that the code specified after the => arrow will be executed
            {
                // Stop the music when the playGame form is closed
                player.Stop();
            };
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Options Options = new Options();

            // Show the second form
            Options.Show();

            // Close the first form (optional, if new)
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button_score_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Score Score = new Score();

            // Show the second form
            Score.Show();

            // Close the first form (optional, if new)
            this.Hide();
        }
    }
}