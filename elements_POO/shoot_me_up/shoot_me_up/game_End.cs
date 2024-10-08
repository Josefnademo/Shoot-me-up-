using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace shoot_me_up
{
    internal class game_End
    {
        playGame playGameInst = new playGame();

        //method of diying ship
        public static PictureBox Life(PictureBox pictureBoxShip, string boomPath)
        {
           int xPosition = pictureBoxShip.Location.X;
           int yPosition = pictureBoxShip.Location.Y;
            boomPath = Form1.boom;  //path of boom picture 

            //make an explosion if hp of ship is 0
            if (playGame.ShipHp == 0)
            {

                PictureBox boom1 = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize, // Adjust the size of image
                    Tag = "boom",                           // Set the tag for identification
                    Left = xPosition,                       //  X position
                    Top = yPosition                         //  Y position     
                };
                using (Image img = Image.FromFile(boomPath)) // Загружаем уникальное изображение ракеты
                {
                    boom1.Image = new Bitmap(img); // Создаем новый Bitmap из загруженного изображения
                }

                return boom1;
            }
            else
            {
                // Ship is not dead, no explosion
                return null;  // Or handle this differently based on your logic
            }
        }
        //

    }
}
