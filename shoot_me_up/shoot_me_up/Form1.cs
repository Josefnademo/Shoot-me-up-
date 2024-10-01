//Author: Yosef Nademo
//Date   : 30.09.2024
//Place  : ETML
//Descr. : Main menu of game "SHOOT ME UP!", with buttons:Optioins,Play,Score and logo of game. 

using System.Media;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class Form1 : Form
    {

        public static bool musicPlaying = true; //variable wich will track the state of music.

        //arrey of all music
        public static string[] musicList =
        { @"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\music\Radiohead-No-Surprises.wav",
          @"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\music\Messages-from-the-stars1.wav",
          @"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\music\a minute lofi.wav",
         @"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\music\Doja_Cat_Ft_SZA_-_Kiss_Me_More.wav"
        };

        //Player declaration, *static* pour que player puisse utiliser par tout
        public static SoundPlayer player;

        public Form1()
        {
            InitializeComponent();

            //Music of score
            if (musicPlaying)
            {
                Form1.player = new SoundPlayer(Form1.musicList[1]);
                Form1.player.PlayLooping();
                musicPlaying = true;
            }
            else
            {
                Form1.player = new SoundPlayer(Form1.musicList[1]);
                Form1.player.PlayLooping();
                musicPlaying = true;
            }
        }

        //PlayGame form opener 
        private void button1_Click(object sender, EventArgs e)
        {

            //stop music of menu
            player.Stop();

            // Create an instance of the second form
            playGame playGame = new playGame();

            // Show the second form
            playGame.Show();

            // Close the first form (optional, if new)
            this.Hide();

            //music of game round
            player = new SoundPlayer(musicList[0]);

            //Start the music when button PLAY is pressed and play it in the loop
            player.PlayLooping();

            // Subscription to the close event of the playGame form
            playGame.FormClosed += (s, args) =>         //=>: This is part of the lambda expression, which says that the code specified after the => arrow will be executed.
            {
                // Stop the music when the playGame form is closed
                player.Stop();
            };
        }

        //score options opener
        private void button_score_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Score Score = new Score();

            // Show the second form
            Score.Show();

            // Close the first form (optional, if new)
            this.Hide();
        }

        //Options button opener
        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Options Options = new Options();

            // Show the second form
            Options.Show();

            // Close the first form (optional, if new)
            this.Hide();

        }

        //button to Stop/Exit program
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Skins form opener
        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Skins Skins1 = new Skins();

            // Show the second form
            Skins1.Show();

            // Close the first form (optional, if new)
            this.Hide();
        }
    }
}