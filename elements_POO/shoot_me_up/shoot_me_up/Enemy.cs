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
    public class Enemy : PictureBox
    {    
        public static string enemyImagePath = Path.GetFullPath(Path.Combine(Form1.basePath, @"..\..\..\..\..\..\images\programing_img\imgonline-com-ua-Resize-zScTrh8xmY-Photoroom.png")); //enemy image
        private playGame gameForm;                          //instance of playGame form
        private Mars gameFormMars;                          //instance of Mars form


        private System.Windows.Forms.Timer movementTimer;   //timer of enemies movement
        private System.Windows.Forms.Timer shootingTimer;   //timer of enemies bullets
        private bool canShoot;                              //state of enemies blasters

        private int direction = 1;                          // 1 for right, -1 for left
        private int speed = 10;                             // Horizontal speed
        private int verticalSpeed = 200;                    // Vertical speed for downward movement
        private int moveDownDistance = 70;                  // Distance to move down after hitting screen edge


        /// <summary>
        /// Initializes a new instance of the Enemy class. 
        /// This constructor sets the properties for the enemy, including its size, background color, and tag. 
        /// It also loads the enemy image and initializes movement and shooting timers. 
        /// The enemy is initially allowed to shoot.
        /// </summary>
        public Enemy()
        {
            
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
            using (Image bulletImage = Image.FromFile(@"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\images\programing_img\bullets\enemy_bullet.png"))
            {
                missile.Image = new Bitmap(bulletImage);
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

            LoadBulletImage(missile);

            if (missile != null)     //just to be sure that this issue won't happen again
            {
                this.Parent.Controls.Add(missile);
            }
            else
            {
                // Handle the case when missile is null
                Console.WriteLine("Missile is null.");
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
                if (missile.Bounds.IntersectsWith(((playGame)this.Parent).pictureBoxShip.Bounds))
                {
                    playGame.ShipHp -= 1; // Decrease player health
                    missileTimer.Stop(); // Stop the missile timer
                    this.Parent.Controls.Remove(missile); // Remove the missile from the form
                    missile.Dispose(); // Dispose of the missile

                   // Remove pictureBox2 (heart)
                   
                        this.Controls.Remove(gameForm.pictureBox2);
                        gameForm.pictureBox2.Dispose();
                   

                    canShoot = true; // Allow the enemy to shoot again
                    return; // Exit the method

                }

                // Check for collision with obstacles
                PictureBox[] obstacles = { ((playGame)this.Parent).pictureBox7, ((playGame)this.Parent).pictureBox8, ((playGame)this.Parent).pictureBox9 };
                for (int i = 0; i < obstacles.Length; i++)
                {
                    if (missile.Bounds.IntersectsWith(obstacles[i].Bounds))
                    {
                        // Reduce the HP of the obstacle
                        if (i == 0) // pictureBox7
                            playGame.obstacle1HP -= 1;
                        else if (i == 1) // pictureBox8
                            playGame.obstacle2HP -= 1;
                        else if (i == 2) // pictureBox9
                            playGame.obstacle3HP -= 1;

                        // Check if the obstacle's HP has reached 0
                        if (i == 0 && playGame.obstacle1HP <= 0)
                        {
                            // Remove the obstacle from the parent controls
                            this.Parent.Controls.Remove(obstacles[i]);
                            obstacles[i].Dispose(); // Dispose of the obstacle to free resources
                            obstacles[i] = null; // Clear reference to prevent future issues
                            playGame.CreateExplosionObstacle(obstacles[i], Form1.boom);
                        }


                        else if (i == 1 && playGame.obstacle2HP <= 0)
                        {
                            // Remove the obstacle from the parent controls
                            this.Parent.Controls.Remove(obstacles[i]);
                            obstacles[i].Dispose(); // Dispose of the obstacle to free resources
                            obstacles[i] = null; // Clear reference to prevent future issues
                            playGame.CreateExplosionObstacle(obstacles[i], Form1.boom);
                        }

                        else if (i == 2 && playGame.obstacle3HP <= 0)
                        {
                            // Remove the obstacle from the parent controls
                            this.Parent.Controls.Remove(obstacles[i]);
                            obstacles[i].Dispose(); // Dispose of the obstacle to free resources
                            obstacles[i] = null; // Clear reference to prevent future issues
                            playGame.CreateExplosionObstacle(obstacles[i], Form1.boom);
                        }

                        // Stop the missile and clean up
                        missileTimer.Stop();
                        this.Parent.Controls.Remove(missile);
                        missile.Dispose();
                        canShoot = true; // Allow the enemy to shoot again
                        return; // Exit the method
                    }
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





