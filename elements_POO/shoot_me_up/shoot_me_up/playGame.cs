﻿// Author: Yosef Nademo
// Date   : 30.09.2024
// Place  : ETML
// Descr. : Deplacement of Spaceship...

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.AxHost;

namespace shoot_me_up
{
    public partial class playGame : Form
    {
        private game_End game_End;                              // game_end instance
        private Enemy enemy;                                    // Enemy instance
        private Pause PauseMenu;                                // Pause instance
        private System.Windows.Forms.Timer missileTimer;        // missile timer

        /// </Gameover window>
        bool GameOver;

        /// </Player>
        private bool moveLeft, moveRight;                        // variables to verify the state of left and right movement
        public int shipSpeed = 15;                               // speed of ship
        public static int ShipHp = 3;                            // ship's hp amount
        bool shooting;                                           // variable to verify shooting process(fire missile method) 

        public static int obstacle1HP = 3;                       // obstacle 1 hp amount
        public static int obstacle2HP = 3;                       // obstacle 2 hp amount
        public static int obstacle3HP = 3;                       // obstacle 3 hp amount
        ///

        /// </Enemy>
        private List<Enemy> enemies; // List to hold enemies
        private const int EnemySpacing = 100; // Space between enemies

        /// </Timer>
        private System.Windows.Forms.Timer movementTimer;


        public playGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering. This helps avoid flickering and improves graphics performance.

            // Start the music of game round when button PLAY is pressed and play it in the loop
            Form1.player = new SoundPlayer(Form1.musicList[0]);
            Form1.player.PlayLooping();

            // Defines the form to handle keystrokes
            this.KeyPreview = true;

            // Subscribe/Use to the KeyDown and KeyUp events
            this.KeyDown += new KeyEventHandler(playGame_KeyDown);
            this.KeyUp += new KeyEventHandler(playGame_KeyUp);

            // Initialize the timer for ship movement
            movementTimer = new System.Windows.Forms.Timer();
            movementTimer.Interval = 2; // Interval
            movementTimer.Tick += new EventHandler(SpaceshipTimer_Tick);
            movementTimer.Start(); // launch the timer of ship

            // Initialize the timer for missile movement
            missileTimer = new System.Windows.Forms.Timer(); // Specify the correct timer class
            missileTimer.Interval = 20; // Adjust interval as needed
            missileTimer.Tick += new EventHandler(MoveMissiles);

            // Add enemies to the game
            enemies = new List<Enemy>();
            SpawnEnemies(); // Call the method to spawn enemies

        }
          

        // Processing of ship movement to left and right
        protected void SpaceshipTimer_Tick(object sender, EventArgs e)
        {
            if (moveLeft && pictureBoxShip.Location.X > 0) // Restriction for left border
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X - shipSpeed, pictureBoxShip.Location.Y);
            }
            if (moveRight && pictureBoxShip.Location.X + pictureBoxShip.Width < this.ClientSize.Width) // Restriction for right border
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X + shipSpeed, pictureBoxShip.Location.Y);
            }
        }


        // Add enemy to the game
        private void SpawnEnemies()
        {
            int startX = 150; // Initial X position for the first enemy
            int yPosition = 50; // Y position for the enemies

            for (int i = 0; i < 5; i++) // Spawn 3 enemies
            {
                Enemy enemy = new Enemy();
                enemy.Location = new Point(startX + (i * EnemySpacing), yPosition);
                this.Controls.Add(enemy); // Add enemy to the form
                enemies.Add(enemy); // Store reference to the enemy
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
            // teleport on center
            if (e.KeyCode == Keys.Up)
            {
                // Move PictureBox on center of Form
                pictureBoxShip.Left = this.ClientSize.Width / 2;
            }

            // shoot with bullet 
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                FireMissile();
            }

            // pause form ACTIVATOR
            if (e.KeyCode == Keys.Escape)
            {
                if (PauseMenu == null)
                {
                    // Create an instance of the second form
                    PauseMenu = new Pause();

                    // Subscribe to the FormClosed event to reset PauseMenu when it's closed
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

        // looking for key liberation
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

        // movement of rocket
        protected void FireMissile()
        {
            int missileY = pictureBoxShip.Location.Y - 20; // Spawn above the spaceship
            int missileX = pictureBoxShip.Location.X + (pictureBoxShip.Width / 2); // Center the missile on the ship

            if (this.Controls.OfType<PictureBox>().Count(m => m.Tag?.ToString() == "missile") < 25) // max 25 missiles
            {
                // create object with 3 variables and data assigned to them
                PictureBox missile = Missile.CreateMissile(missileX, missileY, Missile.missileImage[0]);
                missile.Tag = "missile";    // Set the tag for identification
                this.Controls.Add(missile); // add missile
            }
            // Start the missile timer if it's not already running
            if (!missileTimer.Enabled)
            {
                missileTimer.Start(); // start timer
            }
        }

        // deplacement missile
        private void MoveMissiles(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox missile && missile.Tag?.ToString() == "missile") // Check if control is a missile
                {
                    missile.Top -= 10; // Move the missile upwards

                    // Check for collision with enemies
                    foreach (var enemy in enemies)
                    {
                        if (enemy.Bounds.IntersectsWith(missile.Bounds)) // Collision detection
                        {
                            // Remove missile and enemy on collision
                            this.Controls.Remove(missile);
                            missile.Dispose();
                            this.Controls.Remove(enemy);
                            enemies.Remove(enemy);
                            break; // Exit the loop after removing enemy
                        }
                    }

                    // Remove the missile if it goes off-screen
                    if (missile.Top < 0)
                    {
                        this.Controls.Remove(missile);
                        missile.Dispose();
                    }
                }
            }
        }

        public void RemovePictureBox(PictureBox pb)
        {
            if (pb != null && this.Controls.Contains(pb))
            {
                this.Controls.Remove(pb);
                pb.Dispose(); // Free up resources
            }
        }

      

        // pause form ACTIVATOR
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

        // hide label "Esc to pause"
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Hide();
            timer1.Stop();
        }


        // Victory condition
        private void Victory()
        {
            if (enemies.Count == 0)
            {
                victory_ victoryForm = new victory_();
                victoryForm.Show();
                this.Enabled = false;
            }
        }

        // Method to create an explosion effect at specified positions
        public static PictureBox CreateExplosionObstacle(PictureBox pictureBoxShip, string boomPath)
        {
            // Check if the ship's HP is zero
            if (pictureBoxShip.Tag == null || (int)pictureBoxShip.Tag > 0) return null; // Assuming Tag stores HP

            // Define the explosion positions for each obstacle
            var explosionPositions = new Dictionary<Point, Func<bool>>
    {
        { new Point(355, 554), () => obstacle1HP-- == 0 }, // Position for pictureBox7_Click
        { new Point(614, 554), () => obstacle2HP-- == 0 }, // Position for pictureBox8_Click
        { new Point(889, 554), () => obstacle3HP-- == 0 }  // Position for pictureBox9_Click
    };

            // Create the explosion PictureBox
            PictureBox explosion = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Tag = "explosion"
            };

            // Check each position for collision and create explosion if HP is zero
            foreach (var position in explosionPositions)
            {
                // Call the action to decrease HP and check if it became zero
                if (position.Value.Invoke()) // Check if HP is now zero
                {
                    explosion.Left = position.Key.X;
                    explosion.Top = position.Key.Y;

                    using (Image img = Image.FromFile(boomPath))
                    {
                        explosion.Image = new Bitmap(img);
                    }

                    // Add explosion to the parent control
                    ((Form)pictureBoxShip.Parent).Controls.Add(explosion);
                    return explosion; // Exit after creating the explosion at the first collision
                }
            }

            return null; // Return null if no explosion was created
        }

        // Method to create an explosion effect
        public static PictureBox CreateExplosion(PictureBox pictureBoxShip, string boomPath)
        {
            if (playGame.ShipHp > 0) return null; // Only create explosion if ShipHp is zero

            PictureBox explosion = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Tag = "explosion",
                Left = pictureBoxShip.Location.X,
                Top = pictureBoxShip.Location.Y
            };

            using (Image img = Image.FromFile(boomPath))
            {
                explosion.Image = new Bitmap(img);
            }

            return explosion;
        }

        // Method to handle end-game actions
        private void EndGame()
        {
            movementTimer.Stop();
            missileTimer.Stop();
            MessageBox.Show("Game Over!");
            this.Enabled = false;
        }



        // Game over handler with explosion effect
        private void Game_over()
        {
            if (ShipHp <= 0)
            {
                PictureBox explosion = CreateExplosion(pictureBoxShip, Form1.boom);
                if (explosion != null)
                {
                    this.Controls.Add(explosion); // Add explosion to form controls
                }

                // Wait a sec before showing game over message
        Task.Delay(1000).ContinueWith(_ => EndGame()); // Delay to show explosion before game over
 
            }
            else
            {
                Victory(); // Check for victory if ShipHp is not zero
            }
        }


        private void label2_Click_1(object sender, EventArgs e) { }
        private void pictureBox2_Click_2(object sender, EventArgs e) { }
        private void pictureBoxShip_Click_1(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void HP_Click(object sender, EventArgs e) { }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HP_Click_1(object sender, EventArgs e)
        {

        }

        //obstacle1
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        //obstacle2
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        //obstacle3
        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void playGame_Load(object sender, EventArgs e) { }
    }
}
