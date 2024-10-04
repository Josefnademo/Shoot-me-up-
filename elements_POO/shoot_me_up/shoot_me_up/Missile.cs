using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace shoot_me_up
{
    internal class Missile
    {

        //arrey of all music
        public static string[] missileImage =
        { @"C:\Users\pn25kdv\Documents\GitHub\Shoot-me-up-\images\programing_img\bullets\blue_blas.png",
          @""
        };

        //Creation and positioning of missile
        public static PictureBox CreateMissile(int xPosition , int yPosition)
        {
            PictureBox missile = new PictureBox();
            missile.Image = Image.FromFile(missileImage[0]); // choose the image of missile
            missile.SizeMode = PictureBoxSizeMode.AutoSize; // Adjust the size of image
            missile.Tag = "missile"; // Set the tag for identification
            missile.Left = xPosition; //  X position
            missile.Top = yPosition;  //  Y position
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