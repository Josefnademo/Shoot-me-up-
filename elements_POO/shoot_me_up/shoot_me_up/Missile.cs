using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace shoot_me_up
{
    internal class Missile
    {

        
            public static string basePath = AppDomain.CurrentDomain.BaseDirectory;
            public static string musicPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\..\..\..\images\programing_img\bullets"));

            public static string[] missileImage = // Array of missile images
            {
            Path.Combine(musicPath, "blue_blas.png"),
            Path.Combine(musicPath, "fire_hand.png"),
            Path.Combine(musicPath, "neptun.png")
            // Remove or handle the audio file if it's not needed here
        };

            // Create and position a missile given a unique image
            public static PictureBox CreateMissile(int xPosition, int yPosition, string missileImagePath)
            {
                PictureBox missile = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize, // Adjust the size of image
                    Tag = "missile", // Set the tag for identification
                    Left = xPosition, // X position
                    Top = yPosition // Y position     
                };

                using (Image img = Image.FromFile(missileImagePath)) // Load unique missile picture 
                {
                    missile.Image = new Bitmap(img); // Create new Bitmap from downloaded image
                }

                return missile;
            }



            // Method to move the missile upwards
            public static void MoveMissile(PictureBox missile)
            {
                if (missile.Top > 0) // Ensure it doesn't move off the screen
                {
                    missile.Top -= 10; // Adjust this value for missile speed
                }
                else
                {
                    // If it goes off-screen, remove it
                    missile.Parent.Controls.Remove(missile);
                    missile.Dispose(); // Dispose of the missile to free resources
                }
            }

        // Method to check collision with an enemy
        public static void CheckCollisionWithEnemy(PictureBox missile, Control enemy)
        {
            if (missile.Bounds.IntersectsWith(enemy.Bounds))
            {
                // Handle collision: Remove the missile and the enemy
                missile.Parent.Controls.Remove(missile);
                missile.Dispose(); // Dispose of the missile

                // Call the Hit method on the enemy
                if (enemy is Enemy enemyObj)
                {
                    enemyObj.Hit(); // Call the Hit method to remove the enemy
                }
            }
        }
    }
    }

/*Possible "SizeMode" values:
Normal: The image is displayed at its natural size. If the image is larger than the PictureBox, it will be cropped.
StretchImage: The image is stretched or compressed to fit the dimensions of the PictureBox.
AutoSize: The PictureBox automatically adjusts its size to fit the image.
CenterImage: The image is centered within the PictureBox.
Zoom: The image is scaled proportionally to fit the PictureBox, maintaining its aspect ratio.*/