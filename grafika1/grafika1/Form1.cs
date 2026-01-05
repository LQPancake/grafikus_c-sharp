using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SzamInput1_TextChanged(object sender, EventArgs e)
        {
        }

        private void SzamInput2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Szoroz_Click(object sender, EventArgs e)
        {
            int Szam1 = int.Parse(SzamInput1.Text);
            int Szam2 = int.Parse(SzamInput2.Text);
            int eredmeny = Szam1 * Szam2;
            Eredmeny.Text = eredmeny.ToString();
        }

        private void Osszead_Click(object sender, EventArgs e)
        {
            int Szam1 = int.Parse(SzamInput1.Text);
            int Szam2 = int.Parse(SzamInput2.Text);
            int eredmeny = Szam1 + Szam2;
            Eredmeny.Text = eredmeny.ToString();
        }

        private void Eredmeny_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox bg = new PictureBox();
            bg.Dock = DockStyle.Fill;
            bg.Image = Image.FromFile("skeleton-running-past.gif");
            bg.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(bg);
            bg.SendToBack();

        }
    }
}