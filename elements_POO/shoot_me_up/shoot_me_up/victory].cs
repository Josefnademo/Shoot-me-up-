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

        //choose your next level
        private void label2_Click(object sender, EventArgs e)
        {
            Skins Skins1 = new Skins();
            Skins1.Show();
            this.Hide();
        }

        //back to menu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Form2 = new Form1();
            Form2.Show();
            this.Hide();
        }
    }
}
