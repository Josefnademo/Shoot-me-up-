/******************************************************************************************************
** PROGRAMME  Victory.cs                                                                            **
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
** La classe Victory gère l'affichage de l'écran de victoire lorsque le joueur termine un niveau ou   **
** atteint un objectif spécifique dans le jeu. Elle fournit une interface pour célébrer la victoire,  **
** ainsi que des options pour poursuivre le jeu ou retourner au menu principal.                     **
**                                                                                                    **
** Les principales fonctionnalités de la classe Victory comprennent :                               **
** - Affichage d'un message de félicitations et de statistiques de performance du joueur.           **
** - Options pour sélectionner le niveau suivant ou revenir au menu principal.                       **
** - Gestion des événements d'entrée utilisateur pour permettre au joueur de naviguer facilement     **
**   entre les options disponibles.                                                                   **
**                                                                                                    **
** Cette classe vise à renforcer la satisfaction du joueur en célébrant ses succès et en offrant     **
** des choix clairs pour continuer l'aventure, rendant l'expérience de jeu plus engageante et        **
** gratifiante.                                                                                      **
******************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class victory_ : Form
    {
        /// <summary>
        /// Initializes a new instance of the victory_ form.
        /// </summary>
        public victory_()
        {
            InitializeComponent();
        }

        private void victory__Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the click event for label2, which allows the player to choose the next level. 
        /// It opens the Skins form and hides the current victory form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        //choose your next level
        private void label2_Click(object sender, EventArgs e)
        {
           
            Skins Skins1 = new Skins();
            Skins1.Show();
            this.Hide();
        }


        /// <summary>
        /// Handles the click event for pictureBox1, which allows the player to return to the main menu. 
        /// It creates an instance of the main menu form and hides the current victory form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        //back to menu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Form2 = new Form1();
            Form2.Show();
            this.Hide();
        }
    }
}
