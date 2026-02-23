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

namespace blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEgyenleg_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            groupBoxTetOpciok.Visible = true;
            buttonStart.Visible = false;
        }

        private void textBoxEgyenleg_TextChanged_1(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("egyenleg.txt");
            try
            {
                textBoxEgyenleg.Text = sr.ReadLine();
            }
            catch
            {
                MessageBox.Show("Nincs elegendő egyenleged!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxBlackjack.Visible = true;
            groupBoxTetOpciok.Visible = false;
        }

        private void buttonAlapTet_Click(object sender, EventArgs e)
        {
            groupBoxBlackjack.Visible = true;
            groupBoxTetOpciok.Visible = false;
        }

        private void buttonNagyTet_Click(object sender, EventArgs e)
        {
            groupBoxBlackjack.Visible = true;
            groupBoxTetOpciok.Visible = false;
        }
    }
}