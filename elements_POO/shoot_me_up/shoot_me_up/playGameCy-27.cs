using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class playGameCy_27 : Form
    {
        private Pause PauseMenu;

        /// </Gameover window>
        bool GameOver;

        /// </Player>
        private bool moveLeft, moveRight;
        int shipSpeed = 15;
        public int hp = 3;
        bool shooting;


        /// </Enemy>
        int enemySpeed = 5;
        int score = 0;
        PictureBox[] enemyArray;

        /// </Timer>
        private System.Windows.Forms.Timer movementTimer;


        public playGameCy_27()
        {
            InitializeComponent();

            //Start the music of game round when button PLAY is pressed and play it in the loop
            Form1.player = new SoundPlayer(Form1.musicList[0]);
            Form1.player.PlayLooping();

            // Defines the form to handle keystrokes
            this.KeyPreview = true;

            // Subscribe/Use  to the KeyDown and KeyUp events
            this.KeyDown += new KeyEventHandler(playGame_KeyDown);
            this.KeyUp += new KeyEventHandler(playGame_KeyUp);

        }
        // Traitement du mouvement du navire vers la gauche et la droite
        private void SpaceshipTimer_Tick(object sender, EventArgs e)
        {
            if (moveLeft && pictureBoxShip.Location.X > 0) // Restriction pour la bordure gauche
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X - shipSpeed, pictureBoxShip.Location.Y);
            }
            if (moveRight && pictureBoxShip.Location.X + pictureBoxShip.Width < this.ClientSize.Width) // Limite pour la bordure droite
            {
                pictureBoxShip.Location = new Point(pictureBoxShip.Location.X + shipSpeed, pictureBoxShip.Location.Y);
            }
        }


        // The method that will be called when some key is pressed
        private void playGame_KeyDown(object sender, KeyEventArgs e)
        {

            // Check if the "left arrow" or "A" was pressed
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = true;


            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = true;

            }
            //

            // teleport on center
            if (e.KeyCode == Keys.Up)
            {
                //Move PictureBox on center of Form
                pictureBoxShip.Left = this.ClientSize.Width / 2;
            }
            //

            // shoot with bullet 
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
            }
            //

            //shooting
            if (e.KeyCode == Keys.Escape)
            {
                if (PauseMenu == null)
                {
                    // Create an instance of the second form
                    PauseMenu = new Pause();

                    // Subscribe to the FormClosed event to reset PauseMenu when it's closed //assigning the PauseMenu variable a null value.
                    PauseMenu.FormClosed += (s, args) => PauseMenu = null;

                    // Show the second form
                    PauseMenu.Show();
                }
                else
                {
                    PauseMenu.Close();
                }
            }
            //
        }

        // Gère la libération de la clé
        private void playGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
        }
        //

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (PauseMenu == null)
            {
                // Create a new instance of the PauseMenu form
                PauseMenu = new Pause();

                // Subscribe to the FormClosed event to reset PauseMenu when it's closed //assigning the PauseMenu variable a null value.
                PauseMenu.FormClosed += (s, args) => PauseMenu = null;

                // Show the PauseMenu form
                PauseMenu.Show();
            }
            else
            {
                PauseMenu.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        //hide label "Esc to pause"
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Hide();
            timer1.Stop();
        }

        private void pictureBoxShip_Click(object sender, EventArgs e)
        {

        }
    }
}
