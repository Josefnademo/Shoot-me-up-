//Author: Yosef Nademo
//Date   : 30.09.2024
//Place  : ETML
//Descr. : Main menu of game "SHOOT ME UP!", with buttons:Optioins,Play,Score and logo of game. 

using System.Media;
using System.Windows.Forms;
using System.IO;

namespace shoot_me_up
{
    public partial class Form1 : Form
    {
        public static string basePath = AppDomain.CurrentDomain.BaseDirectory;                                   //get the Path of current program
        public static string boom = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\..\..\images\boom.png")); //game over boom png
        public static string musicPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\..\..\..\music"));   //combine the Path of current program and music folder and give it as full path
        public static bool musicPlaying = true;                                                                  //variable wich will track the state of music.
        public static SoundPlayer player;                                                                        //Player declaration, *static* pour que player puisse utiliser par tout
        public static string[] musicList =                                                                       //arrey of all music
        {
            Path.Combine(musicPath,"Radiohead-No-Surprises.wav"),
            Path.Combine(musicPath,"Messages-from-the-stars1.wav"),
            Path.Combine(musicPath,"a minute lofi.wav"),
            Path.Combine(musicPath,"Doja_Cat_Ft_SZA_-_Kiss_Me_More.wav"),
            Path.Combine(musicPath,"Oy-Marichka-Chicheri.wav")
        };

        public Form1()
        {
            InitializeComponent();
            
            //*Music checking* if "musicPLaying" is turned off,so music doesn't playing
            if (musicPlaying == true)
            {
                // Check if the file exists **to don't stop the program
                if (File.Exists(musicList[1])) 
                {
                    player = new SoundPlayer(Form1.musicList[1]);
                    player.PlayLooping();
                    musicPlaying = true;
                }
                else
                {
                    MessageBox.Show("Music file not found (0w0): " + musicList[1]);   //if file of music isn't found messageBox apears
                }
            }
        }
        //PlayGame form opener 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //stop music of menu
            player.Stop();

            // Create an instance of the second form
            playGame playGame = new playGame();

            // Show the second form
            playGame.Show();

            // Close the first form (optional, if new)
            this.Hide();
        }
        // Skins form opener
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Skins Skins1 = new Skins();
            Skins1.Show();
            this.Hide();
        }
        // Score form opener
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Score Score = new Score();
            Score.Show();
            this.Hide();
        }
        // Optioons form opener
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Options Options = new Options();
            Options.Show();
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
    }
}


/////// I USED this code to close play.Game and stop his music, but i found better way to do this easier ///////
/*// Subscription to the close event of the playGame form
            playGame.FormClosed += (s, args) =>         //=>: This is part of the lambda expression, which says that the code specified after the => arrow will be executed.
            {
                // Stop the music when the playGame form is closed
                player.Stop();
            };*/