//Author: Yosef Nademo
//Date   : 13.09.2024
//Place  : ETML
//Descr. : Main menu of game "SHOOT ME UP!", with buttons:Optioins,Play,Score and logo of game. 

namespace shoot_me_up
{
    public partial class Form1 : Form
    {
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
    }
}