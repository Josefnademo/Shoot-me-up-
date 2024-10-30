using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoot_me_up
{
    public class Enemy : PictureBox
    {    
        public static string enemyImagePath = Path.GetFullPath(Path.Combine(Form1.basePath, @"..\..\..\..\..\..\images\programing_img\imgonline-com-ua-Resize-zScTrh8xmY-Photoroom.png")); //enemy image
        private playGame gameForm;
       
        private System.Windows.Forms.Timer movementTimer;   //timer of enemies movement
        private System.Windows.Forms.Timer shootingTimer;   //timer of enemies bullets
        private bool canShoot;                              //state of enemies blasters

        private int direction = 1;                          // 1 for right, -1 for left
        private int speed = 5;                              // Horizontal speed
        private int verticalSpeed = 20;                     // Vertical speed for downward movement
        private int moveDownDistance = 70;                  // Distance to move down after hitting screen edge


        //enemy - mesures of enemy
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
        //enemy picture adding
        private void LoadEnemyImage()
        {
            using (Image enemyImage = Image.FromFile(enemyImagePath))
            {
                this.Image = new Bitmap(enemyImage);
                this.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust to fit
            }
        }

        //bullet picture adding
        private void LoadBulletImage(PictureBox missile)
        {
            using (Image bulletImage = Image.FromFile(@"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\images\programing_img\bullets\enemy_bullet.png"))
            {
                missile.Image = new Bitmap(bulletImage);
                missile.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust to fit
            }
        }

        //timer for enemies  mouvements
        private void InitializeMovementTimer()
        {
            movementTimer = new System.Windows.Forms.Timer
            {
                Interval = 10 // Change direction every second
            };
            movementTimer.Tick += (s, e) => Move();
            movementTimer.Start();
        }

        //timer for cooldown of enemies bullet
        private void InitializeShootingTimer()
        {
            shootingTimer = new System.Windows.Forms.Timer
            {
                Interval = 4000 // Shoot every 4 seconds
            };
            shootingTimer.Tick += (s, e) => Shoot();
            shootingTimer.Start();
        }

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

        public void Shoot()
        {
            if (!canShoot) return;

            int missileX = this.Left + (this.Width / 2) - 2;
            int missileY = this.Top + this.Height;

            PictureBox missile = new PictureBox
            {
                Tag = "enemyMissile",
                Size = new Size(43, 113),                    // Set the size for the bullet
                Location = new Point(missileX, missileY),
                BackColor = Color.Transparent                // Make background transparent for image visibility
            };

            LoadBulletImage(missile);

            // Add missile to the form
            this.Parent.Controls.Add(missile);

            canShoot = false; // Set the flag to false, indicating the enemy cannot shoot

            var missileTimer = new System.Windows.Forms.Timer
            { Interval = 2};


            missileTimer.Tick += (s, args) =>
            {
                missile.Top += 25; // Move missile down
                if (missile.Top >= this.Parent.ClientSize.Height)
                {

                    missileTimer.Stop(); // Stop the timer
                    this.Parent.Controls.Remove(missile); // Remove the missile from the form
                    missile.Dispose(); // Dispose of the missile to free resources

                    canShoot = true; // Allow the enemy to shoot again
                }

                // Check for collision with the player
                if (missile.Bounds.IntersectsWith(((playGame)this.Parent).pictureBoxShip.Bounds))
                {
                    // Handle the collision
                    playGame.ShipHp -= 1; // Decrease player HP

                    

                    missileTimer.Stop(); // Stop the timer
                    missile.Dispose(); // Dispose of the missile to free resources
                    this.Parent.Controls.Remove(missile); // Remove the missile from the 
                    return; // Exit to avoid further processing
                }


                // Check for collision with obstacles
                foreach (var obstacle in this.Parent.Controls.OfType<PictureBox>().Where(p => p.Tag?.ToString() == "obstacle"))
                {
                    if (missile.Bounds.IntersectsWith(obstacle.Bounds))
                    {
                        // Decrease obstacle's HP
                        obstacle.Tag = (int.Parse(obstacle.Tag.ToString()) - 1).ToString(); // Decrease HP by 1

                        // If HP reaches 0, remove the obstacle
                        if (int.Parse(obstacle.Tag.ToString()) <= 0)
                        {
                            this.Parent.Controls.Remove(obstacle); // Remove obstacle
                            obstacle.Dispose(); // Dispose of the obstacle to free resources
                        }

                        missileTimer.Stop();
                        missile.Dispose();
                        this.Parent.Controls.Remove(missile);
                        return; // Exit to avoid further processing
                    }
                }

            };
            missileTimer.Start();
        }

        //remove/kill enemy 
        public void Hit()
        {
            // Remove the enemy from the parent control
            this.Parent.Controls.Remove(this);
            this.Dispose(); // Dispose of the enemy to free resources
        }
    }
}





