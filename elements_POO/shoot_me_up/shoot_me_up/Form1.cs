/******************************************************************************
** PROGRAMME  shoot_me_up.cs                                                **
**                                                                           **
** Lieu      : ETML - section informatique                                   **
** Auteur    : Yosef Nademo                                                  **
** Date      : 01.11.2024                                                    **
**                                                                           **
** Modifications                                                             **
**   Auteur  :                                                               **
**   Version :                                                               **
**   Date    :                                                               **
**   Raisons :                                                               **
**                                                                           **
**                                                                           **
******************************************************************************/

/******************************************************************************************************
** DESCRIPTION                                                                                       ** 
** Ce programme est un jeu de type Space Invaders en 2D où le joueur contrôle un vaisseau spatial    ** 
** qui doit tirer sur des déchets spatiaux avec des missiles. L'objectif du jeu est de               ** 
** détruire le plus de déchets possible tout en évitant de se faire toucher par ceux-ci.             ** 
** Le joueur doit naviguer sur l'écran, tirer des missiles, et gérer ses ressources                  ** 
** pour maximiser son score.                                                                         ** 
**                                                                                                   ** 
** Le jeu propose plusieurs niveaux, chacun présentant des défis uniques, tels que                   ** 
** des types de déchets différents et des schémas de mouvement variés. De plus,                      ** 
** des éléments de power-up sont disponibles pour améliorer les capacités du vaisseau,               ** 
** comme la vitesse de tir et la résistance.                                                         ** 
**                                                                                                   ** 
** Le programme utilise une interface graphique conviviale, permettant au joueur                     ** 
** de naviguer facilement entre les menus, d'accéder aux options, de consulter le                    ** 
** classement et de sélectionner des skins pour personnaliser son vaisseau.                          ** 
** Les effets sonores et la musique de fond ajoutent une dimension immersive au jeu,                 ** 
** rendant l'expérience de jeu plus engageante.                                                      ** 
**                                                                                                   ** 
** Les principales fonctionnalités comprennent :                                                     ** 
** - Tirer des missiles pour détruire des déchets.                                                   ** 
** - Différents niveaux de difficulté avec des défis croissants.                                     ** 
** - Système de score pour suivre les performances du joueur.                                        ** 
** - Options de personnalisation pour le vaisseau.                                                   ** 
** - Musique et effets sonores immersifs.                                                            ** 
**                                                                                                   ** 
** Ce programme vise à offrir une expérience de jeu amusante et captivante, tout en                  ** 
** sensibilisant aux problèmes de pollution spatiale.                                                ** 
******************************************************************************************************/



/******************************************************************************************************
** PROGRAMME  Form1.cs                                                                               **
**                                                                                                    **
** Lieu      : ETML - section informatique                                                          **
** Auteur    : Yosef Nademo                                                                         **
** Date      : 01.11.2024                                                                           **
**                                                                                                    **
** Modifications                                                                                    **
**   Auteur  :                                                                                      **
**   Version :                                                                                      **
**   Date    :                                                                                     **
**   Raisons :                                                                                     **
**                                                                                                    **
******************************************************************************************************/

/******************************************************************************************************
** DESCRIPTION                                                                                       ** 
** La classe Form1 représente l'écran principal du jeu, agissant comme le point de départ de l'expérience de jeu.**
** Elle permet aux joueurs d'accéder à différentes fonctionnalités et options disponibles dans le jeu.  **
**                                                                                                    **
** Les principales fonctionnalités de la classe Form1 comprennent :                                 **
** - Chargement et lecture de la musique de fond, améliorant l'ambiance du jeu.                      **
** - Navigation vers les autres écrans du jeu, y compris le jeu principal, les options, les skins, et le classement.**
** - Gestion des événements utilisateur à travers des clics sur les éléments de l'interface graphique.   **
** - Affichage de messages d'erreur en cas de fichiers manquants ou d'autres problèmes liés à la musique.**
**                                                                                                    **
** Form1 est essentielle pour l'interaction initiale du joueur avec le jeu, fournissant une interface  **
** utilisateur conviviale pour commencer l'aventure de tir spatial.                                   **
******************************************************************************************************/



using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace shoot_me_up
{
    public partial class Form1 : Form
    {
        public static string basePath = AppDomain.CurrentDomain.BaseDirectory;                                   //get the Path of current program
        public static string boom = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\..\..\images\boom.png")); //game over boom png
        public static string musicPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\..\..\..\music"));   //combine the Path of current program and music folder and give it as full path
        public static string scorePath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\..\..\..\score"));   //score fullpath
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


        /// <summary>
        /// Initializes the main menu form, sets up music playback, and manages resource paths.
        /// </summary>
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

        /// <summary>
        /// Handles the click event for the "Play Game" button, stopping the current music 
        /// and opening the playGame form while hiding the main menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        //PlayGame form opener 
        private void pictureBox2_Click_1(object sender, EventArgs e)
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


        /// <summary>
        /// Handles the click event for the "Skins" button, opening the Skins form 
        /// and hiding the main menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        // Skins form opener
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Skins Skins1 = new Skins();
            Skins1.Show();
            this.Hide();
        }

        /// <summary>
        /// Handles the click event for the "Score" button, opening the Score form 
        /// and hiding the main menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        // Score form opener
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Score Score = new Score();
            Score.Show();
            this.Hide();
        }


        /// <summary>
        /// Handles the click event for the "Options" button, opening the Options form 
        /// and hiding the main menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        // Optioons form opener
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Options Options = new Options();
            Options.Show();
            this.Hide();
        }

        /// <summary>
        /// Handles the click event for the "Exit" button, closing the application.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        //button to Stop/Exit program
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
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