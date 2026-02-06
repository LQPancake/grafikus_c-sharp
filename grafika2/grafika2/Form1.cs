using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int FizetendoOsszesen { get; set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cukorSok.Checked == true)
            { labelEredmeny.Text = "Sok cukor"; }
            else { labelEredmeny.Text = "Nem sok cukor"; }
            if (ButtonFizetes.Text == "Fizetés")
            {
                ButtonBankkartya.Visible = true;
                ButtonKp.Visible = true;
                ButtonFizetes.Text = "Mégsem";
            }
            else
            {
                ButtonBankkartya.Visible = false;
                ButtonKp.Visible = false;
                ButtonFizetes.Text = "Fizetés";
                groupBoxKpFizet.Visible = false;
            }
        }

        private void tea_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
            checkboxCitrom.Enabled = true;
            checkboxCitrom.Checked = false;
            checkboxKavekrem.Enabled = false;
            checkboxTejpor.Enabled = false;
            checkboxTejszin.Enabled = false;
            checkboxTejszin.Checked = false;
            checkboxKavekrem.Checked = false;
            checkboxTejpor.Checked = false;
        }

        private void espresso_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
            IngredientsSettings();
        }

        private void duplaKave_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
            IngredientsSettings();
        }

        private void hosszuKave_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
            IngredientsSettings();
        }
        private void IngredientsSettings()
        {
            checkboxCitrom.Enabled = false;
            checkboxCitrom.Checked = false;
            checkboxKavekrem.Enabled = true;
            checkboxTejpor.Enabled = true;
            checkboxTejszin.Enabled = true;
            checkboxTejszin.Checked = false;
            checkboxKavekrem.Checked = false;
            checkboxTejpor.Checked = false;
        }

        private void Calculator()
        {
            int ital = 0, hozzavalo = 0, cukor = 0;
            if (espresso.Checked) { ital = +140; }
            if (duplaKave.Checked) { ital = +200; }
            if (hosszuKave.Checked) { ital = +170; }
            if (tea.Checked) { ital = +120; }
            textBoxItalAr.Text = ital.ToString();
            if(checkboxCitrom.Checked) { hozzavalo += 20; }
            if(checkboxKavekrem.Checked) { hozzavalo += 40; }
            if(checkboxTejpor.Checked) { hozzavalo += 25; }
            if(checkboxTejszin.Checked) { hozzavalo += 30; }
            textBoxHozzavaloAr.Text = hozzavalo.ToString();
            if(cukorKeves.Checked) { cukor += 60; }
            if(cukorSok.Checked) { cukor += 10; }
            textBoxCukorAr.Text = cukor.ToString();
            textBoxOsszesenAr.Text = (ital + hozzavalo + cukor).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkboxKavekrem_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void checkboxTejszin_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void checkboxTejpor_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void checkboxCitrom_CheckedChanged(object sender, EventArgs e)
        {
            Calculator();
        }

        private void ButtonBankkartya_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A kártyaolvasó nem működik, sajnálom!","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void ButtonKp_Click(object sender, EventArgs e)
        {
            groupBoxKpFizet.Visible = true;
        }

        private void labelEredmeny_Click(object sender, EventArgs e)
        {

        }

        private void labelTajekoztatas_Click(object sender, EventArgs e)
        {

        }

        private void buttonPenzBedob_Click(object sender, EventArgs e)
        {
            int keszpenz = int.Parse(textBoxEgyenleg.Text);
            if (keszpenz == FizetendoOsszesen)
            {
                labelEredmeny.Text = "Elegendő összeg";
            }
            else if(keszpenz > FizetendoOsszesen)
            {
                labelEredmeny.Text = $"Visszajáró: {keszpenz - FizetendoOsszesen}";
            }
            else
            {
                labelEredmeny.Text = "Nem elegendő összeg";
            }
        }

        private void groupBoxKpFizet_Enter(object sender, EventArgs e)
        {

        }
    }
}