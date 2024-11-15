/******************************************************************************************************
** PROGRAMME  Skins.cs                                                                               **
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
** La classe Skins gère l'interface de personnalisation des vaisseaux spatiaux dans le jeu. Elle     **
** permet aux joueurs de sélectionner différents skins pour leur vaisseau, offrant ainsi une        **
** expérience de jeu plus personnalisée et attrayante.                                             **
**                                                                                                    **
** Les principales fonctionnalités de la classe Skins comprennent :                                 **
** - Affichage d'une galerie de skins disponibles, avec des aperçus visuels pour chaque option.     **
** - Gestion des sélections de skins par le joueur, permettant de sauvegarder les préférences.      **
** - Intégration des skins sélectionnés dans le jeu, modifiant l'apparence du vaisseau.             **
**                                                                                                    **
** La classe contribue à l'immersion et à l'engagement des joueurs, en leur offrant la possibilité   **
** de personnaliser leur expérience de jeu et de se démarquer grâce à des visuels uniques.          **
******************************************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class Skins : Form
    {
        public static bool musicPlaying = true; //variable wich will track the state of music.
        public static SoundPlayer player;
        public Skins()
        {
            InitializeComponent();

            //Music of score
            if (musicPlaying)
            {
                Skins.player = new SoundPlayer(Form1.musicList[3]);
                Skins.player.PlayLooping();
                musicPlaying = false;
            }
            else
            {
                Form1.player = new SoundPlayer(Form1.musicList[3]);
                Form1.player.PlayLooping();
                musicPlaying = true;
            }
        }

        private void Skins_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //1 level spaceX
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the second form
            playGame playGame = new playGame();

            // Show the second form
            playGame.Show();

            // Close the first form (optional, if new)
            this.Close();
        }

        //2 level Mars 
        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Mars mars = new Mars();

            // Show the second form
            mars.Show();

            // Close the first form (optional, if new)
            this.Close();
        }

        //3 level Cy-27 
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the 3d form
            playGameCy_27 mars = new playGameCy_27();

            // Show the second form
            mars.Show();

            // Close the first form (optional, if new)
            this.Close();
        }


        //back button
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Form1 Menu = new Form1();

            // Show the second form
            Menu.Show();

            // Close the first form (optional, if new)
            this.Close();
        }

        private void Skins_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

    }
}

