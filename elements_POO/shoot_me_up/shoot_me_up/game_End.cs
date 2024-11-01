/******************************************************************************************************
** PROGRAMME  game_End.cs                                                                           **
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
** La classe game_End gère la fin du jeu, affichant un écran de résultats et permettant au joueur de   **
** consulter ses performances après avoir terminé une partie.                                       **
**                                                                                                    **
** Les principales fonctionnalités de la classe game_End comprennent :                              **
** - Affichage des scores finaux, des statistiques de performance et des messages de félicitations,   **
**   offrant au joueur un retour sur son expérience de jeu.                                          **
** - Options pour redémarrer le jeu ou retourner au menu principal, permettant une navigation facile.  **
** - Gestion des événements de fermeture du jeu, assurant que les ressources sont libérées correctement.**
**                                                                                                    **
** Cette classe est essentielle pour conclure l'expérience de jeu, en fournissant une interface       **
** conviviale pour que les joueurs puissent voir leurs réalisations et choisir leurs prochaines étapes.**
******************************************************************************************************/


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
           int xPosition = pictureBoxShip.Location.X;    //X location of picture 
           int yPosition = pictureBoxShip.Location.Y;    //Y location of picture 
            boomPath = Form1.boom;                       //path of boom picture 

            //make an explosion if hp of ship is 0
            if (playGame.ShipHp <= 0)
            {

                PictureBox boom1 = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize, // Adjust the size of image
                    Tag = "boom",                           // Set the tag for identification
                    Left = xPosition,                       //  X position
                    Top = yPosition                         //  Y position     
                };

                //loading image of explosion
                using (Image img = Image.FromFile(boomPath)) // loading rocket img
                {
                    boom1.Image = new Bitmap(img); // creating new bitmap and loading it
                }
                return boom1;

            }
            else
            {
                // Ship is not dead, no explosion
                return null;  
            }
        }
       
    }
}
