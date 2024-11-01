/******************************************************************************************************
** PROGRAMME  Missile.cs                                                                             **
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
** La classe Missile gère la création, le mouvement et la collision des missiles tirés par le vaisseau.**
** Elle permet de simuler les projectiles dans le jeu et d'interagir avec les ennemis.                 **
**                                                                                                    **
** Les principales fonctionnalités de la classe Missile comprennent :                                 **
** - Création de missiles avec une image et une position initiale spécifiées, permettant d'utiliser  **
**   différents types de projectiles.                                                                 **
** - Déplacement des missiles vers le haut de l'écran, avec une gestion de la vitesse et de la       **
**   suppression des missiles hors écran pour économiser les ressources.                              **
** - Vérification des collisions entre les missiles et les ennemis, permettant de déclencher des     **
**   événements lorsque les missiles touchent une cible, comme détruire l'ennemi et supprimer le      **
**   missile.                                                                                        **
**                                                                                                    **
** La classe Missile joue un rôle crucial dans le gameplay, car elle permet aux joueurs de défendre    **
** leur vaisseau contre les déchets spatiaux et d'engager des combats contre les ennemis.            **
******************************************************************************************************/


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
        
            public static string basePath = AppDomain.CurrentDomain.BaseDirectory;                                                           //get the Path of current program
            public static string bulletPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\..\..\..\images\programing_img\bullets"));  //path of missile images

            public static string[] missileImage = // Array of missile images
            {
            Path.Combine(bulletPath, "blue_blas.png"),
            Path.Combine(bulletPath, "fire_hand.png"),
            Path.Combine(bulletPath, "neptun.png") 
            };


        /// <summary>
        /// Creates a missile PictureBox with a specified position and image.
        /// </summary>
        /// <param name="xPosition">The X coordinate for the missile's position.</param>
        /// <param name="yPosition">The Y coordinate for the missile's position.</param>
        /// <param name="missileImagePath">The file path of the missile image to be used.</param>
        // Create and position a missile given a unique image
        public static PictureBox CreateMissile(int xPosition, int yPosition, string missileImagePath)
            {
                PictureBox missile = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize, // Adjust the size of image
                    Tag = "missile", // Set the tag for identification
                    Left = xPosition, // X position
                    Top = yPosition, // Y position
                    BackColor = Color.Transparent // Make background transparent for image visibility
                 };

                using (Image img = Image.FromFile(missileImagePath)) // Load unique missile picture 
                {
                    missile.Image = new Bitmap(img); // Create new Bitmap from downloaded image
                }

                return missile;
            }


        /// <summary>
        /// Moves the missile upwards on the screen.
        /// </summary>
        /// <param name="missile">The missile PictureBox to move.</param>
        // Method to move the missile upwards
        public static void MoveMissile(PictureBox missile)
            {
                if (missile.Top > 0) // Ensure it doesn't move off the screen
                {
                    missile.Top -= 15; // value ща missile speed
                }
                else
                {
                    // If it goes off-screen, remove it
                    missile.Parent.Controls.Remove(missile);
                    missile.Dispose(); // Dispose of the missile to free resources
                }
            }


        /// <summary>
        /// Checks for a collision between the missile and an enemy.
        /// </summary>
        /// <param name="missile">The missile PictureBox.</param>
        /// <param name="enemy">The enemy control to check for collision with.</param>
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