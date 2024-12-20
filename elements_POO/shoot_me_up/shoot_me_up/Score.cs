﻿/******************************************************************************************************
** PROGRAMME  Score.cs                                                                               **
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
** La classe Score est responsable de la gestion du système de scores dans le jeu. Elle permet de   **
** suivre et d'afficher le score du joueur tout au long de la partie.                               **
**                                                                                                    **
** Les principales fonctionnalités de la classe Score comprennent :                                 **
** - Calcul et mise à jour du score en fonction des actions du joueur, telles que la destruction de  **
**   déchets ou l'accomplissement d'objectifs spécifiques.                                           **
** - Affichage du score en temps réel à l'écran, permettant aux joueurs de suivre leurs performances.**
** - Gestion des scores élevés, permettant aux joueurs de comparer leurs résultats avec ceux des autres.**
** - Possibilité de sauvegarder et de charger les scores, assurant une continuité entre les sessions. **
**                                                                                                    **
** La classe Score contribue à la compétitivité du jeu, en incitant les joueurs à améliorer leurs     **
** performances et à viser de nouveaux records.                                                     **
******************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class Score : Form
    {

        public Score()
        {
            InitializeComponent();

            //Music of score
            Form1.player = new SoundPlayer(Form1.musicList[2]);
            Form1.player.PlayLooping();
        }

        //back to menu button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Form1 Form2 = new Form1();

            // Show the second form
            Form2.Show();

            // Close the first form (optional, if new)
            this.Hide();
        }

        private void Score_Load(object sender, EventArgs e)
        {

        }
    }
}
