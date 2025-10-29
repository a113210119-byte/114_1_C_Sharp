using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_pg._131
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Eight of Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Two of Clubs";
        }

        private void pictureBoxK_Click(object sender, EventArgs e)
        {
            labelResult.Text = "King of Spades";
        }

        private void pictureBoxA_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Ace of Spades";
        }

        private void pictureBoxJoker_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Joker";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
