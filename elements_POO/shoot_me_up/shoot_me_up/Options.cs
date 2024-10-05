//Author: Yosef Nademo
//Date   : 30.09.2024
//Place  : ETML
//Descr. : Options menu of game "SHOOT ME UP!", with buttons:+Sound,-Sonud,Label of Sound options and logo of Options menu. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;            // Library for working with audio of system

namespace shoot_me_up
{
    public partial class Options : Form
    {

        public static Form1 Menu = new Form1();         // Create an instance of the Form1
        private CoreAudioDevice defaultPlaybackDevice;  // Create an instance of the class to work with audio devices

        public Options()
        {
            InitializeComponent();

            // Get the default device (speakers, headphones, etc.)
            defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        }

        //button to go back to menu
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Show the second form
            Menu.Show();

            // Close the first form (optional, if new)
            this.Close();
        }

        //button to stop and turn on music, use methode of class Pause
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pause.ToggleMusic(); //Form1.musicPlaying= false;
        }

        //diminuate the volume button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (defaultPlaybackDevice.Volume >= 5 && defaultPlaybackDevice.Volume <= 100)
            {
                // Get the current volume
                int currentVolume = (int)defaultPlaybackDevice.Volume;
                // Decrease volume by 5
                defaultPlaybackDevice.Volume = currentVolume - 5;
            }
        }
        //Increase the volume button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (defaultPlaybackDevice.Volume >= 0 && defaultPlaybackDevice.Volume < 100)
            {
                // Get the current volume
                int currentVolume = (int)defaultPlaybackDevice.Volume;
                // Increase volume by 5
                defaultPlaybackDevice.Volume = currentVolume + 5;
            }
        }

        private void button_score_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
