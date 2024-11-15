﻿/******************************************************************************************************
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
        private game_End game_End;                                                    // game_end instance
        private Enemy enemy;                                                          // Enemy instance
        private Pause PauseMenu;                                                      // Pause instance
        private System.Windows.Forms.Timer missileTimer;                              // missile timer

        /// <state of game- info>
        bool GameOver;                                                                // game over bool
        private bool isVictoryShown = false;                                          // victory state    


        /// <Player>
        private bool moveLeft, moveRight, moveDown, moveUp;     //variables to verify the state of left and right movement
        public int shipSpeed = 15;                                                    // speed of ship
        public static int ShipHp = 3;                                                 // ship's hp amount
        bool shooting;                                                                // variable to verify shooting process(fire missile method) 


        public static int obstacle1HP = 3;                                            // obstacle 1 hp amount
        public static int obstacle2HP = 3;                                            // obstacle 2 hp amount
        public static int obstacle3HP = 3;                                            // obstacle 3 hp amount

        private int score = 0;                                                        // Variable to hold the current score
        private string scoreFilePath = Path.Combine(Form1.scorePath, "score-1Level-Galaxy.txt");    // Path for score file
        private Label scoreLabel;                                                     // Label to display score on the screen


        public static int Score { get; set; } = 0; // Property to keep track of score

        /// <Enemy>
        private List<Enemy> enemies;                                                  // List to hold enemies
        private const int EnemySpacing = 100;                                         // Space between enemies

        /// <Timer>
        private System.Windows.Forms.Timer movementTimer;                             // timer for movement


        /// <summary>
        /// Initializes a new instance of the playGame form.
        /// This constructor sets up the game environment, including graphics settings,
        /// sound playback, keyboard input handling, timers for movement and missile firing,
        /// and initializes game elements such as enemies and the score.
        /// </summary>
        public playGameCy_27()
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

            score = 0; // Initialisez le score à zéro
            DisplayScore(); // Affichez le score au démarrage
            LoadScore(); // Ajoutez cette ligne
            DisplayScore(); // Affichez le score chargé
        }





        /// <summary>
        /// Handles the timer tick event for spaceship movement.
        /// Moves the spaceship left or right based on player input while ensuring it stays within the form's boundaries.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
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

        /// <summary>
        /// Spawns a specified number of enemies at predetermined positions in the game.
        /// Initializes each enemy instance and adds it to the form and the enemy list.
        /// </summary>
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

        /// <summary>
        /// Loads the player's score from a file if it exists.
        /// Updates the score variable with the loaded value.
        /// </summary>
        private void LoadScore()
        {
            if (File.Exists(scoreFilePath)) // verify existing of file
            {
                string scoreText = File.ReadAllText(scoreFilePath);
                if (int.TryParse(scoreText, out int loadedScore))
                {
                    score = loadedScore;
                }
            }
        }


        /// <summary>
        /// Saves the current player's score to a file.
        /// </summary>
        private void SaveScore()
        {
            File.WriteAllText(scoreFilePath, score.ToString()); // path creation on file
        }

        /// <summary>
        /// Displays the current score on the form's label and saves the score to a file.
        /// Updates the label text to reflect the current score.
        /// </summary>
        private void DisplayScore()
        {
            label1.Text = "Score: " + score;
            SaveScore(); // save score
        }






        /// <summary>
        /// Handles key down events for the game, allowing for player movement, shooting, and pausing the game.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing the key pressed information.</param>
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
                    this.Enabled = false;     //make playGame form not availble (stops it)
                }
                else
                {
                    PauseMenu.Close();
                    this.Enabled = true;     //make playGame form  availble (run it)
                }
            }
        }

        /// <summary>
        /// Handles key up events, stopping the movement of the ship when keys are released.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing the key released information.</param>
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

        /// <summary>
        /// Fires a missile from the spaceship's position.
        /// </summary>
        protected void FireMissile()
        {
            int missileY = pictureBoxShip.Location.Y - 20; // Spawn above the spaceship
            int missileX = pictureBoxShip.Location.X + (pictureBoxShip.Width / 2); // Center the missile on the ship

            // Check for the maximum number of missiles
            if (this.Controls.OfType<PictureBox>().Count(m => m.Tag?.ToString() == "missile") < 25) // max 25 missiles
            {
                // Create the missile PictureBox
                PictureBox missile = Missile.CreateMissile(missileX, missileY, Missile.missileImage[0]);
                missile.Tag = "missile"; // Set the tag for identification
                this.Controls.Add(missile); // Add missile to the control

                // Bring the missile to the front to ensure it appears above other controls
                missile.BringToFront();

                // Start the missile timer if it's not already running
                if (!missileTimer.Enabled)
                {
                    missileTimer.Start(); // Start the timer
                }
            }
        }


        /// <summary>
        /// Checks for victory conditions in the game, displaying the victory form if conditions are met.
        /// </summary>
        private void Victory()
        {
            if (enemies.Count <= 0 && !isVictoryShown)
            {

                victory_ victoryForm = new victory_();
                victoryForm.Show();
                this.Enabled = false;     //make playGame form not availble (stops it)
            }
        }

        /// <summary>
        /// Moves missiles upwards and checks for collisions with enemies and the screen bounds.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data associated with the timer tick.</param>
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

                            //  add 100 to score
                            score += 100; // +100 score
                            DisplayScore(); // update score

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

            // Check for victory condition after processing all missiles and enemies
            if (enemies.Count == 0 && !isVictoryShown)
            {
                Victory();
                isVictoryShown = true;   //change state of flag
            }
        }

        /// <summary>
        /// Removes a specified PictureBox control from the form, disposing of its resources.
        /// </summary>
        /// <param name="pb">The PictureBox control to remove.</param>
        public void RemovePictureBox(PictureBox pb)
        {
            if (pb != null && this.Controls.Contains(pb))
            {
                this.Controls.Remove(pb);
                pb.Dispose(); // Free up resources
            }

            if (ShipHp == 2)
            {
                this.Controls.Remove(HP1);
                this.HP1.Dispose();
            }
            if (ShipHp == 1)
            {
                this.Controls.Remove(HP2);
                this.HP2.Dispose();
            }
            if (ShipHp == 0)
            {
                this.Controls.Remove(HP3);
                this.HP3.Dispose();

                Game_over();
            }
        }


        /// <summary>
        /// Handles the click event for the pause button (pictureBox4).
        /// Toggles the pause menu visibility and the state of the game.
        /// If the pause menu is not currently displayed, it creates and shows the PauseMenu,
        /// disabling the playGame form to prevent interaction. If the pause menu is already displayed,
        /// it closes the menu and re-enables the playGame form, allowing gameplay to resume.
        /// </summary>
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (PauseMenu == null)
            {
                PauseMenu = new Pause();
                PauseMenu.FormClosed += (s, args) => PauseMenu = null;
                PauseMenu.Show();
                this.Enabled = false;     //make playGame form not availble (stops it)
            }
            else
            {
                PauseMenu.Close();
                this.Enabled = true;     //make playGame form  availble (run it)
            }
        }

        /// <summary>
        /// Hides the "Esc to pause" label after a timer tick.
        /// This method is called periodically to manage the visibility of the label,
        /// ensuring it only appears temporarily during gameplay.
        /// </summary>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Hide();
            timer1.Stop();
        }

        /// <summary>
        /// Creates an explosion effect at specified positions when an obstacle is destroyed.
        /// The explosion positions are predefined for each obstacle, and this method checks
        /// the health points (HP) of the obstacles to determine when to create an explosion.
        /// </summary>
        /// <param name="pictureBoxShip">The PictureBox representing the player's ship.</param>
        /// <param name="boomPath">The file path to the explosion image.</param>
        public static void CreateExplosionObstacle(PictureBox pictureBoxShip, string boomPath)
        {


            // Define the explosion positions for each obstacle
            var explosionPositions = new Dictionary<Point, Func<bool>>
    {
        { new Point(355, 554), () => obstacle1HP <= 0 }, // Position for obstacle 1
        { new Point(614, 554), () => obstacle2HP <= 0 }, // Position for obstacle 2
        { new Point(889, 554), () => obstacle3HP <= 0 }  // Position for obstacle 3
    };


        }


        /// <summary>
        /// Checks if obstacles were hit by a missile and handles their health points accordingly.
        /// If an obstacle is hit and its HP drops to zero, it removes the obstacle from the game.
        /// This method is called whenever a missile collides with an obstacle.
        /// </summary>
        /// <param name="obstacle">The PictureBox representing the obstacle that was hit.</param>
        protected void HandleObstacleHit(PictureBox obstacle)
        {
            if (obstacle == pictureBox2 && obstacle1HP > 0)
            {
                obstacle1HP--;
                CreateExplosionObstacle(pictureBox2, Form1.boom);
            }
            else if (obstacle == pictureBox8 && obstacle2HP > 0)
            {
                obstacle2HP--;
                CreateExplosionObstacle(pictureBox8, Form1.boom);
            }
            else if (obstacle == pictureBox9 && obstacle3HP > 0)
            {
                obstacle3HP--;
                CreateExplosionObstacle(pictureBox9, Form1.boom);
            }

            // Remove the obstacle if HP reaches zero
            if (obstacle1HP == 0) this.Controls.Remove(pictureBox7);
            if (obstacle2HP == 0) this.Controls.Remove(HP2);
            if (obstacle3HP == 0) this.Controls.Remove(pictureBox9);
        }

        /// <summary>
        /// Creates an explosion effect at a specified position.
        /// This method initializes a PictureBox for the explosion, loads the explosion image,
        /// and adds it to the form. It also sets up a delay to remove the explosion after a short duration.
        /// </summary>
        /// <param name="position">The position where the explosion should occur.</param>
        /// <param name="boomPath">The file path to the explosion image.</param>
        public void CreateExplosion(Point position, string boomPath)
        {
            PictureBox boom = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = position, // Set the location to the given position
                Tag = "explosion"
            };

            // Load explosion image
            using (Image img = Image.FromFile(boomPath))
            {
                boom.Image = new Bitmap(img); // Create a new bitmap from the loaded image
            }

            // Add the explosion to the parent controls
            this.Parent.Controls.Add(boom);

            // Optional: Set a timer to remove the explosion after a short duration
            Task.Delay(1000).ContinueWith(_ =>
            {
                if (boom.InvokeRequired)
                {
                    boom.Invoke((MethodInvoker)(() => this.Parent.Controls.Remove(boom)));
                }
                else
                {
                    this.Parent.Controls.Remove(boom);
                }
                boom.Dispose(); // Dispose of the explosion effect to free resources
            });
        }


        /// <summary>
        /// Handles actions to be taken at the end of the game.
        /// This includes stopping movement and missile timers, displaying the game over message,
        /// and managing cleanup of game resources.
        /// </summary>
        private void EndGame()
        {
            movementTimer.Stop();
            missileTimer.Stop();
            Game_over(); // Call Game_over to handle explosions and game over logic
            MessageBox.Show("Game Over!");
            this.Enabled = false;
        }


        /// <summary>
        /// Handles the logic for the game over scenario.
        /// It checks the player's ship health and determines if an explosion effect should be created.
        /// If the ship's HP is zero, it creates an explosion at the ship's location.
        /// It also checks for enemy conditions and handles their removal from the game.
        /// </summary>
        private void Game_over()
        {
            // Get the X and Y location of the player's ship
            int xPosition = pictureBoxShip.Location.X;
            int yPosition = pictureBoxShip.Location.Y;
            string boomPath = Form1.boom;                // Path of the explosion image

            // Check if the ship's HP is 0
            if (ShipHp <= 0)
            {
                // Create an explosion effect at the ship's location
                CreateExplosion(new Point(xPosition, yPosition), boomPath);

                // Delay before ending the game
                Task.Delay(1000).ContinueWith(_ => EndGame());
                return; // Exit to prevent further execution in this method
            }

            // Ship is not dead, no explosion; check for enemy conditions
            foreach (var enemy in this.Controls.OfType<Enemy>()) // Assuming Enemy is a class for your enemies
            {
                if (enemy.Top >= this.Parent.ClientSize.Height)
                {
                    this.Parent.Controls.Remove(enemy); // Remove the enemy from the form
                    enemy.Dispose(); // Dispose of the enemy to free resources
                    EndGame(); // End the game
                }
            }
        }

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

        private void playGameCy_27_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxShip_Click(object sender, EventArgs e)
        {

        }

        private void playGameCy_27_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
