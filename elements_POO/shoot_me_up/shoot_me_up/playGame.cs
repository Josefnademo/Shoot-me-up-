//Author: Yosef Nademo
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
        private Missile MissileForm;
        private System.Windows.Forms.Timer missileTimer;

        /// </Gameover window>
        bool GameOver;

        /// </Player>
        private bool moveLeft, moveRight;
        int shipSpeed = 15;
        public int hp = 3;
        bool shooting;
        

        /// </Enemy>
        int enemySpeed = 5;
        int score = 0;
        PictureBox[] enemyArray;

        /// </Timer>
        private System.Windows.Forms.Timer movementTimer;


        public playGame()
        {
            InitializeComponent();

            //Start the music of game round when button PLAY is pressed and play it in the loop
            Form1.player = new SoundPlayer(Form1.musicList[0]);
            Form1.player.PlayLooping();

            // Defines the form to handle keystrokes
            this.KeyPreview = true;

            // Subscribe/Use  to the KeyDown and KeyUp events
            this.KeyDown += new KeyEventHandler(playGame_KeyDown);
            this.KeyUp += new KeyEventHandler(playGame_KeyUp);

            // Initialize the timer for missile movement
            missileTimer = new System.Windows.Forms.Timer(); // Specify the correct timer class
            missileTimer.Interval = 20; // Adjust interval as needed
            missileTimer.Tick += new EventHandler(MoveMissiles);

        }
        // Traitement du mouvement du navire vers la gauche et la droite
        protected void SpaceshipTimer_Tick(object sender, EventArgs e)
        {
            if (moveLeft && pictureBoxShip.Location.X > 0) // Restriction pour la bordure gauche
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X - shipSpeed, pictureBoxShip.Location.Y);
            }
            if (moveRight && pictureBoxShip.Location.X + pictureBoxShip.Width < this.ClientSize.Width) // Limite pour la bordure droite
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X + shipSpeed, pictureBoxShip.Location.Y);
            }

        }

        protected void FireMissile()
        {
            int missileY = pictureBoxShip.Location.Y - 20; // Spawn above the spaceship
            int missileX = pictureBoxShip.Location.X + (pictureBoxShip.Width / 2) ; // Center the missile on the ship
            PictureBox missile = Missile.CreateMissile(missileX, missileY);
            missile.Tag = "missile"; // Set the tag for identification
            this.Controls.Add(missile);

            // Start the missile timer if it's not already running
            if (!missileTimer.Enabled)
            {
                missileTimer.Start();
            }
        }


        // The method that will be called when some key is pressed
        private void playGame_KeyDown(object sender, KeyEventArgs e)
        {

            // Check if the "left arrow" or "A" was pressed
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            //

            // teleport on center
            if (e.KeyCode == Keys.Up)
            {
                //Move PictureBox on center of Form
                pictureBoxShip.Left = this.ClientSize.Width/2;
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

        //pause form ACTIVATOR
        private void pictureBox4_Click_1(object sender, EventArgs e)
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
        // Gère la libération de la clé
        private void playGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
        }
        //

        //hide label "Esc to pause"
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Hide();
            timer1.Stop();
        }
        //
        private void label2_Click_1(object sender, EventArgs e)
        {
            
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

        private void playGame_Load(object sender, EventArgs e)
        {

        }
    }
}
