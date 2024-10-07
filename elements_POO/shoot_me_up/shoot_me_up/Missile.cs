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


        public static string basePath = AppDomain.CurrentDomain.BaseDirectory;                                                               //get the Path of current program
        public static string musicPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\..\..\..\images\programing_img\bullets"));       //combine the Path of current program and music folder and give it as full path
        public static string[] missileImage =                                                                                                //arrey of all music
        {
          Path.Combine(musicPath,"blue_blas.png"),
          Path.Combine(musicPath,"fire_hand.png"),
          Path.Combine(musicPath,"neptun.png"),
          Path.Combine(musicPath,"Radiohead-No-Surprises.wav")
        };

        //// Create and position a rocket given a unique image
        public static PictureBox CreateMissile(int xPosition, int yPosition, string missileImagePath)
        {
            PictureBox missile = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize, // Adjust the size of image
                Tag = "missile", // Set the tag for identification
                Left = xPosition, //  X position
                Top = yPosition //  Y position     
            };
            using (Image img = Image.FromFile(missileImagePath)) // Load unique rocket picture 
            {
                missile.Image = new Bitmap(img); // Create new Bitmap from downloaded image
            }

            return missile;
        }
    }
}

/*Possible "SizeMode" values:
Normal: The image is displayed at its natural size. If the image is larger than the PictureBox, it will be cropped.
StretchImage: The image is stretched or compressed to fit the dimensions of the PictureBox.
AutoSize: The PictureBox automatically adjusts its size to fit the image.
CenterImage: The image is centered within the PictureBox.
Zoom: The image is scaled proportionally to fit the PictureBox, maintaining its aspect ratio.*/