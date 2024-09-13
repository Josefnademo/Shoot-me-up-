//Author: Yosef Nademo
//Date   : 13.09.2024
//Place  : ETML
//Descr. : Options menu of game "SHOOT ME UP!", with buttons:+Sound,-Sonud,Label of Sound options and logo of Options menu. 

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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void button_score_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Form1 Form1 = new Form1();

            // Show the second form
            Form1.Show();

            // Close the first form (optional, if new)
            this.Hide();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
