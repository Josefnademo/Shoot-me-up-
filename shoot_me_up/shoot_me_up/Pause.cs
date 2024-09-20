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
    public partial class Pause : Form
    {
        public Pause()
        {
            InitializeComponent();
        }

        private void Pause_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Continue the game
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Form1 Form2 = new Form1();

            // Show the second form
            Form2.Show();

            // Close the first form (optional, if new)

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
