/******************************************************************************************************
** PROGRAMME  PlayGame.cs                                                                           **
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
** La classe PlayGame représente le cœur du jeu, où le joueur contrôle un vaisseau spatial et       **
** interagit avec divers éléments du jeu, tels que les ennemis, les obstacles, et les missiles.      **
** Cette classe gère la logique de jeu, y compris le mouvement du vaisseau, le tir de missiles, et   **
** les collisions avec les ennemis et les obstacles.                                               **
**                                                                                                    **
** Les principales fonctionnalités de la classe PlayGame comprennent :                             **
** - Initialisation des éléments de jeu, tels que les ennemis, les obstacles et les missiles.       **
** - Gestion des entrées utilisateur pour le mouvement et le tir.                                   **
** - Suivi des scores et des niveaux de vie du joueur.                                              **
** - Détection des collisions et traitement des événements associés, comme la destruction d'ennemis.**
** - Gestion de la pause et de la reprise du jeu.                                                   **
** - Affichage des informations de score et de vie en temps réel.                                   **
**                                                                                                    **
** Cette classe est essentielle pour créer une expérience de jeu dynamique et interactive, où le    **
** joueur peut s'engager pleinement dans l'action tout en faisant face à des défis variés.          **
******************************************************************************************************/


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
    public partial class playGameCy_27 : Form
    {
        private game_End game_End;                              // game_end instance
        private Enemy enemy;                                    // Enemy instance
        private Pause PauseMenu;                                //Pause instance
        private System.Windows.Forms.Timer missileTimer;        //missile timer

        /// </Gameover window>
        bool GameOver;

        /// </Player>
        private bool moveLeft, moveRight, moveDown, moveUp;     //variables to verify the state of left and right movement
        int shipSpeed = 70;                   //speed of ship
        public int hp = 5;                    //ship's hp amount
        bool shooting;                        //variable to verify shooting process(fire missile method) 
                                              //
        public static int obstacle1 = 3;         // obstacle 1 hp amount
        public static int obstacle2 = 3;         // obstacle 2 hp amount
        public static int obstacle3 = 3;         // obstacle 3 hp amount


        /// </Enemy>
        private List<Enemy> enemies; // List to hold enemies
        private const int EnemySpacing = 100; // Space between enemies


        /// </Timer>
        private System.Windows.Forms.Timer movementTimer;


        public playGameCy_27()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering. This helps avoid flickering and improves graphics performance.

            //Start the music of game round when button PLAY is pressed and play it in the loop
            Form1.player = new SoundPlayer(Form1.musicList[2]);
            Form1.player.PlayLooping();

            // Defines the form to handle keystrokes
            this.KeyPreview = true;

            // Subscribe/Use  to the KeyDown and KeyUp events
            this.KeyDown += new KeyEventHandler(playGame_KeyDown);
            this.KeyUp += new KeyEventHandler(playGame_KeyUp);

            // Initialize the timer for ship movement
            movementTimer = new System.Windows.Forms.Timer();
            movementTimer.Interval = 1; // Interval
            movementTimer.Tick += new EventHandler(SpaceshipTimer_Tick);
            movementTimer.Start(); // launch the timer of ship

            // Initialize the timer for missile movement
            missileTimer = new System.Windows.Forms.Timer(); // Specify the correct timer class
            missileTimer.Interval = 20; // Adjust interval as needed
            missileTimer.Tick += new EventHandler(MoveMissiles);


        }
        // Traitement du mouvement du navire vers la gauche et la droite
        protected void SpaceshipTimer_Tick(object sender, EventArgs e)
        {
            //left
            if (moveLeft && pictureBoxShip.Location.X > 0) // Restriction pour la bordure gauche
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X - shipSpeed, pictureBoxShip.Location.Y);
            }
            //right
            if (moveRight && pictureBoxShip.Location.X + pictureBoxShip.Width < this.ClientSize.Width) // Limite pour la bordure droite
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X + shipSpeed, pictureBoxShip.Location.Y);
            }
            //Down
            if (moveDown && pictureBoxShip.Location.Y + pictureBoxShip.Height < this.ClientSize.Height) // Restriction pour la bordure gauche
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X, pictureBoxShip.Location.Y + shipSpeed);

            }
            //Up
            if (moveUp && pictureBoxShip.Location.Y > 0) // Limite pour la bordure droite
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X, pictureBoxShip.Location.Y - shipSpeed);
            }

        }
        //

        //movement of rocket
        protected void FireMissile()
        {
            int missileY = pictureBoxShip.Location.Y - 20; // Spawn above the spaceship
            int missileX = pictureBoxShip.Location.X + (pictureBoxShip.Width / 2); // Center the missile on the ship


            if (this.Controls.OfType<PictureBox>().Count(m => m.Tag?.ToString() == "missile") < 25) //max 25 racket,   m -amount of pictureboxes,  ?.  -(null-conditional operator) 
            {
                //create object with 3 variables and data  assigned to them
                PictureBox missile = Missile.CreateMissile(missileX, missileY, Missile.missileImage[0]);

                missile.Tag = "missile";    // Set the tag for identification
                this.Controls.Add(missile); //add missile
            }

            // Start the missile timer if it's not already running
            if (!missileTimer.Enabled)
            {
                missileTimer.Start();//start timer
            }
        }
        //

        //deplacement missile
        private void MoveMissiles(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox missile && missile.Tag?.ToString() == "missile") //The ?. operator (null-conditional operator) is used to safely access the ToString() method.
                                                                                           //If Tag is null, it won’t throw an exception, and the expression will evaluate to null
                {
                    missile.Top -= 10; // Move the missile upwards

                    // Remove the missile if it goes off-screen
                    if (missile.Top < 0)
                    {
                        this.Controls.Remove(missile);
                        missile.Dispose();
                    }
                }
            }
        }
        //

        // The method that will be called when some key is pressed
        private void playGame_KeyDown(object sender, KeyEventArgs e)
        {

            // Check if the "left arrow"/"right arrow" or "A"/"D" was pressed
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = true;

            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = true;

            }
            //
            // Check if the "left arrow"/"right arrow" or "A"/"D" was pressed
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                moveDown = true;

            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                moveUp = true;

            }
            //

            // teleport on center(cheat with key "C")
            if (e.KeyCode == Keys.C)
            {
                //Move PictureBox on center of Form
                pictureBoxShip.Left = this.ClientSize.Width / 2;
            }
            //

            // shoot with bullet 
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                FireMissile();
            }
            //

            //pause form ACTIVATOR
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
            //
        }

        // Gère la libération de la clé
        private void playGame_KeyUp(object sender, KeyEventArgs e)
        {
            //Left-Right
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            //Down-Up
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
        }
        //

        //pause form ACTIVATOR
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (PauseMenu == null)
            {
                PauseMenu = new Pause();
                PauseMenu.FormClosed += (s, args) => PauseMenu = null;
                PauseMenu.Show();
            }
            else
            {
                PauseMenu.Close();
            }
        }
        //

        //hide label "Esc to pause"
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Hide();
            timer1.Stop();
        }
        //
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxShip_Click(object sender, EventArgs e)
        {

        }

        private void playGameCy_27_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
