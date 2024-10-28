using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoot_me_up
{
    public class Enemy : PictureBox
    {
        private Random random;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Timer shootingTimer;
        private bool canShoot;

        public Enemy()
        {
            random = new Random();
            this.Tag = "enemy";
            this.Size = new Size(83, 84); // Set the size to match your enemy image
            this.BackColor = Color.Transparent; // Make background transparent for image visibility

            LoadEnemyImage();

            InitializeMovementTimer();
            InitializeShootingTimer();

            canShoot = true; // Initially, the enemy can shoot
        }

        private void LoadEnemyImage()
        {
            using (Image enemyImage = Image.FromFile(@"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\images\programing_img\imgonline-com-ua-Resize-zScTrh8xmY-Photoroom.png"))
            {
                this.Image = new Bitmap(enemyImage);
                this.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust to fit
            }
        }

        private void InitializeMovementTimer()
        {
            movementTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // Change direction every second
            };
            movementTimer.Tick += (s, e) => Move();
            movementTimer.Start();
        }

        private void InitializeShootingTimer()
        {
            shootingTimer = new System.Windows.Forms.Timer
            {
                Interval = 2000 // Shoot every 2 seconds
            };
            shootingTimer.Tick += (s, e) => Shoot();
            shootingTimer.Start();
        }

        private void Move()
        {
            int direction = random.Next(0, 4);
            int speed = 5;

            switch (direction)
            {
                case 0: // Move up
                    if (this.Top > 0) this.Top -= speed;
                    break;
                case 1: // Move down
                    if (this.Top + this.Height < this.Parent.ClientSize.Height) this.Top += speed;
                    break;
                case 2: // Move left
                    if (this.Left > 0) this.Left -= speed;
                    break;
                case 3: // Move right
                    if (this.Left + this.Width < this.Parent.ClientSize.Width) this.Left += speed;
                    break;
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
                Size = new Size(43, 113), // Set the size for the bullet
                Location = new Point(missileX, missileY),
                BackColor = Color.Transparent // Make background transparent for image visibility
            };

            LoadBulletImage(missile);

            // Add missile to the form
            this.Parent.Controls.Add(missile);

            canShoot = false; // Set the flag to false, indicating the enemy cannot shoot

            var missileTimer = new System.Windows.Forms.Timer
            {
                Interval = 20
            };
            missileTimer.Tick += (s, args) =>
            {
                missile.Top += 10; // Move missile down
                if (missile.Top > this.Parent.ClientSize.Height)
                {
                    
                    missile.Dispose();
                    canShoot = true; // Reset the flag when the missile is gone
                }

               /* // Check for collision with the player
                if (missile.Bounds.IntersectsWith(((playGame)this.Parent).pictureBoxShip.Bounds))
                {
                    missileTimer.Stop();
                    missile.Dispose();
                    ((playGame)this.Parent).game_End();
                }*/
            };
            missileTimer.Start();
        }

        private void LoadBulletImage(PictureBox missile)
        {
            using (Image bulletImage = Image.FromFile(@"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\images\programing_img\bullets\enemy_bullet.png"))
            {
                missile.Image = new Bitmap(bulletImage);
                missile.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust to fit
            }
        }

        // New method to handle collision with player bullets
        public void CheckCollisionWithPlayerBullet(PictureBox playerBullet)
        {
            if (this.Bounds.IntersectsWith(playerBullet.Bounds))
            {
                // Remove the enemy from the form
                this.Parent.Controls.Remove(this);
                this.Dispose(); // Dispose of the enemy to free resources
            }
        }
        public void Hit()
        {
            // Remove the enemy from the parent control
            this.Parent.Controls.Remove(this);
            this.Dispose(); // Dispose of the enemy to free resources
        }
    }
}





