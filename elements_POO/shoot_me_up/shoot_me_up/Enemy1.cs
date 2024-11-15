/****************************************************************************** 
** CLASS       Enemy                                                          ** 
**                                                                           ** 
** Lieu       : ETML - section informatique                                   ** 
** Auteur     : Yosef Nademo                                                  ** 
** Date       : 01.11.2024                                                    ** 
**                                                                           ** 
** Modifications                                                             ** 
**   Auteur   :                                                               ** 
**   Version  :                                                               ** 
**   Date     :                                                               ** 
**   Raisons  :                                                               ** 
**                                                                           ** 
**                                                                           ** 
******************************************************************************/

/****************************************************************************************************** 
** DESCRIPTION                                                                                     ** 
** La classe Enemy représente un ennemi dans le jeu "shoot_me_up". Les ennemis apparaissent sur    ** 
** l'écran et se déplacent vers le bas, créant un défi pour le joueur qui doit les détruire avant    ** 
** qu'ils ne touchent le vaisseau spatial du joueur. Chaque ennemi peut avoir différentes           ** 
** caractéristiques telles que la santé, la vitesse de déplacement, et des comportements            ** 
** spécifiques lors de l'impact avec des missiles.                                                ** 
**                                                                                                 ** 
** PRINCIPALES FONCTIONNALITÉS :                                                                   ** 
** - Gérer la position et le mouvement des ennemis sur l'écran.                                   ** 
** - Détecter les collisions avec les missiles du joueur.                                          ** 
** - Appliquer des dégâts aux ennemis lorsqu'ils sont touchés par un missile.                       ** 
** - Gérer les animations ou les effets visuels lors de leur destruction.                          ** 
**                                                                                                 ** 
** MÉTHODES PRINCIPALES :                                                                          ** 
** - **Shoot()** : Gère la logique de tir de l'ennemi, si applicable.                              ** 
** - **Hit()** : Applique des dégâts à l'ennemi et vérifie si sa santé atteint zéro, le rendant    ** 
**   inactif.                                                                                      ** 
** - **Move()** : Met à jour la position de l'ennemi à chaque cycle de jeu, simule le mouvement    ** 
**   vers le bas de l'écran.                                                                      ** 
**                                                                                                 ** 
** La classe Enemy contribue à la dynamique de jeu en fournissant des adversaires que le joueur      ** 
** doit surmonter, rendant l'expérience de jeu plus engageante et stimulante.                       ** 
******************************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace shoot_me_up
{
    internal class Enemy1 : PictureBox
    {
        public static string enemyImagePath = Path.GetFullPath(Path.Combine(Form1.basePath, @"..\..\..\..\..\..\images\programing_img\imgonline-com-ua-Resize-zScTrh8xmY-Photoroom.png")); //enemy image
        public static string HeartImagePath = Path.GetFullPath(Path.Combine(Form1.basePath, @"..\..\..\..\..\..\images\programing_img\HEART_EMPTY-Photoroom-Photoroom.png")); //empty heart image
        public static string enemyBulletImagePath = Path.GetFullPath(Path.Combine(Form1.basePath, @"..\..\..\..\..\..\images\programing_img\bullets\enemy_bullet.png")); //enemy's bullet image

        private Mars gameFormMars;                          //instance of Mars form


        private System.Windows.Forms.Timer movementTimer;   //timer of enemies movement
        private System.Windows.Forms.Timer shootingTimer;   //timer of enemies bullets
        private bool canShoot;                              //state of enemies blasters

        private int direction = 1;                          // 1 for right, -1 for left
        private int speed = 20;                             // Horizontal speed
        private int verticalSpeed = 300;                    // Vertical speed for downward movement
        private int moveDownDistance = 85;                  // Distance to move down after hitting screen edge
       

        /// <summary>
        /// Initializes a new instance of the Enemy class. 
        /// This constructor sets the properties for the enemy, including its size, background color, and tag. 
        /// It also loads the enemy image and initializes movement and shooting timers. 
        /// The enemy is initially allowed to shoot.
        /// </summary>
        public Enemy1()
        {
            this.gameFormMars = gameFormMars;
            this.Tag = "enemy";
            this.Size = new Size(83, 84); // Set the size to match your enemy image
            this.BackColor = Color.Transparent; // Make background transparent for image visibility

            LoadEnemyImage();

            InitializeMovementTimer();
            InitializeShootingTimer();

            canShoot = true; // Initially, the enemy can shoot

        }

        /// <summary>
        /// Loads the enemy image from the specified path and applies it to the enemy PictureBox.
        /// </summary>
        private void LoadEnemyImage()
        {
            using (Image enemyImage = Image.FromFile(enemyImagePath))
            {
                this.Image = new Bitmap(enemyImage);
                this.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust to fit
            }
        }

        /// <summary>
        /// Loads the bullet image into the specified missile PictureBox.
        /// </summary>
        /// <param name="missile"></param>
        private void LoadBulletImage(PictureBox missile)
        {
            using (Image bulletImage = Image.FromFile(enemyBulletImagePath))
            {
                missile.Image = new Bitmap(enemyBulletImagePath);
                missile.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust to fit
            }
        }

        /// <summary>
        /// Initializes the movement timer for the enemies.
        /// This timer controls the frequency of enemy movements, 
        /// updating their position every 10 milliseconds.
        /// </summary>
        private void InitializeMovementTimer()
        {
            movementTimer = new System.Windows.Forms.Timer
            {
                Interval = 10 // make move every x msec
            };
            movementTimer.Tick += (s, e) => Move();
            movementTimer.Start();
        }

        /// <summary>
        /// Initializes the shooting timer for the enemy's bullet cooldown.
        /// This timer controls the frequency of enemy shooting, allowing them to fire 
        /// bullets every 4 seconds. The shooting mechanism is triggered in response 
        /// to the timer's Tick event.
        /// </summary>
        private void InitializeShootingTimer()
        {
            shootingTimer = new System.Windows.Forms.Timer
            {
                Interval = 400 // Shoot every 4 seconds
            };
            shootingTimer.Tick += (s, e) => Shoot();
            shootingTimer.Start();
        }

        /// <summary>
        /// Moves the enemy object horizontally across the screen. 
        /// The method checks for collisions with the edges of the parent container and reverses the direction if necessary. 
        /// When a collision with the edge occurs, the enemy also moves down by a specified distance.
        /// </summary>
        private void Move()
        {
            if (this.Parent == null) return; // Exit if there is no parent

            // Move horizontally
            this.Left += direction * speed;

            // Check for collision with screen edges
            if (this.Left + this.Width >= this.Parent.ClientSize.Width + 85 || this.Left <= 0)
            {
                // Change direction and move down
                direction *= -1; // Reverse direction
                this.Top += moveDownDistance; // Move down
            }

        }

        /// <summary>
        /// /// Initiates the shooting action for the enemy character. 
        /// The method checks if the enemy can shoot, creates a missile, and manages its movement.
        /// It handles missile collision detection with the player's ship and obstacles, reducing health accordingly.
        /// If the missile goes off-screen or hits an obstacle, it is removed from the game and disposed of.
        /// </summary>
        public void Shoot()
        {
            if (!canShoot) return;

            int missileX = this.Left + (this.Width / 2) - 2;
            int missileY = this.Top + this.Height;

            PictureBox missile = new PictureBox
            {
                Tag = "enemyMissile",
                Size = new Size(43, 113), // Set the size for the bullet
                Location = new Point(missileX, missileY),
                BackColor = Color.Transparent // Make background transparent for image visibility
            };

            if (missile != null) // Assurez-vous que l'objet missile a été correctement initialisé avant de charger l'image
            {
                LoadBulletImage(missile);

                if (missile.Image != null)     //just to be sure that this issue won't happen again
                {
                    this.Parent.Controls.Add(missile);
                }
                else
                {
                    // Handle the case when missile is null
                    Console.WriteLine("Missile is null.");
                }
            }

            canShoot = false; // Set the flag to false, indicating the enemy cannot shoot

            var missileTimer = new System.Windows.Forms.Timer
            {
                Interval = 2
            };

            missileTimer.Tick += (s, args) =>
            {
                if (missile == null || missileTimer == null || this.Parent == null)
                    return; // if one of object = null, stop processing (exception)

                missile.Top += 25; // Move missile down

                // Check if the missile has gone off-screen
                if (missile.Top >= this.Parent.ClientSize.Height)
                {
                    missileTimer.Stop(); // Stop the timer
                    this.Parent.Controls.Remove(missile); // Remove the missile from the form
                    missile.Dispose(); // Dispose of the missile to free resources
                    canShoot = true; // Allow the enemy to shoot again
                    return; // Exit the method
                }
                

                // Check for collision with the player ship
                if (missile.Bounds.IntersectsWith(((Mars)this.Parent).pictureBoxShip.Bounds))
                {
                    playGame.ShipHp -= 1; // Decrease player health
                    missileTimer.Stop(); // Stop the missile timer
                    this.Parent.Controls.Remove(missile); // Remove the missile from the form
                    missile.Dispose(); // Dispose of the missile

                    if (Mars.ShipHp == 2)
                    {

                        // Create a new PictureBox
                        PictureBox newPictureBox = new PictureBox();

                        // Set the properties of the PictureBox
                        newPictureBox.Location = new Point(112, 2);  // Specify the location on the form
                        newPictureBox.Size = new Size(61, 80);        // Specify the size of the PictureBox
                        newPictureBox.BackColor = Color.Transparent;   // Optional: set background to transparent

                        // Set an image for the PictureBox (ensure the path to the image is correct)
                        newPictureBox.Image = Image.FromFile(HeartImagePath);

                        // Set the image size mode (stretch, zoom, etc.)
                        newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust as needed
                        missile.BringToFront();
                        // Add the PictureBox to the playGame form's controls
                        this.Parent.Controls.Add(newPictureBox);
                    }
                    if (Mars.ShipHp == 1)
                    {

                        // Create a new PictureBox
                        PictureBox newPictureBox = new PictureBox();

                        // Set the properties of the PictureBox
                        newPictureBox.Location = new Point(56, 2);  // Specify the location on the form
                        newPictureBox.Size = new Size(61, 80);        // Specify the size of the PictureBox
                        newPictureBox.BackColor = Color.Transparent;   // Optional: set background to transparent

                        // Set an image for the PictureBox (ensure the path to the image is correct)
                        newPictureBox.Image = Image.FromFile(HeartImagePath);

                        // Set the image size mode (stretch, zoom, etc.)
                        newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust as needed
                        missile.BringToFront();
                        // Add the PictureBox to the playGame form's controls
                        this.Parent.Controls.Add(newPictureBox);
                    }
                    if (Mars.ShipHp == 0)
                    {

                        // Create a new PictureBox
                        PictureBox newPictureBox = new PictureBox();

                        // Set the properties of the PictureBox
                        newPictureBox.Location = new Point(1, 2);  // Specify the location on the form
                        newPictureBox.Size = new Size(61, 80);        // Specify the size of the PictureBox
                        newPictureBox.BackColor = Color.Transparent;   // Optional: set background to transparent

                        // Set an image for the PictureBox (ensure the path to the image is correct)
                        newPictureBox.Image = Image.FromFile(HeartImagePath);

                        // Set the image size mode (stretch, zoom, etc.)
                        newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust as needed
                        missile.BringToFront();
                        // Add the PictureBox to the playGame form's controls
                        this.Parent.Controls.Add(newPictureBox);
                    }

                    canShoot = true; // Allow the enemy to shoot again
                    return; // Exit the method

                }

            };
            missileTimer.Start();
        }




        /// <summary>
        /// Handles actions taken when the enemy is hit and removed.
        /// </summary>
        public void Hit()
        {
            // Remove the enemy from the parent control
            this.Parent.Controls.Remove(this);
            this.Dispose(); // Dispose of the enemy to free resources
        }
    }
}
