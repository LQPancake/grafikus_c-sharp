using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjackSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                StreamReader sr = new StreamReader("egyenleg.txt");
                textBoxEgyenleg.Text = $"{sr.ReadLine()}Ft";
            }
            catch
            {
                MessageBox.Show("Nincs elég egyenleged!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            groupBoxTetek.Visible = false;
            groupBoxBlackjack.Visible = true;
        }

        private void buttonKisTet_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            labelTet.Text = "Tét: 2500Ft";
        }

        private void buttonAlapTet_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            labelTet.Text = "Tét: 5000Ft";
        }

        private void buttonNagyTet_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            labelTet.Text = "Tét: 10000Ft";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelStatusz_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDealerKartyak_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {

        }
    }
}