using BlackjackLibrary;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace blackjackSolution
{
    public partial class Form1 : Form
    {
        BlackjackGame jatek = new BlackjackGame();
        int egyenleg = 0;
        int aktualisTet = 0;
        bool jatekFut = false;

        public Form1()
        {
            InitializeComponent();

            try
            {
                egyenleg = int.Parse(File.ReadAllText("egyenleg.txt"));
                textBoxEgyenleg.Text = $"{egyenleg} Ft";
            }
            catch
            {
                MessageBox.Show("Nincs elég egyenleged!", "Hiba",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            groupBoxBlackjack.Visible = false;
            buttonStart.Visible = false;
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (aktualisTet == 0)
            {
                MessageBox.Show("Válassz tétet!");
                return;
            }

            if (egyenleg < aktualisTet)
            {
                MessageBox.Show("Nincs elég pénzed!");
                return;
            }

            egyenleg -= aktualisTet;
            FrissitEgyenleg();
            jatek.UjJatek();
            FrissitLapok();
            labelStatusz.Text = "";
            groupBoxBlackjack.Visible = true;
            buttonStart.Visible = false;
            buttonHit.Enabled = true;
            buttonStand.Enabled = true;
            jatekFut = true;
        }
        private void buttonKisTet_Click(object sender, EventArgs e)
        {
            aktualisTet = 2500;
            labelTet.Text = "Tét: 2500 Ft";
            buttonStart.Visible = true;
        }
        private void buttonAlapTet_Click(object sender, EventArgs e)
        {
            aktualisTet = 5000;
            labelTet.Text = "Tét: 5000 Ft";
            buttonStart.Visible = true;
        }
        private void buttonNagyTet_Click(object sender, EventArgs e)
        {
            aktualisTet = 10000;
            labelTet.Text = "Tét: 10000 Ft";
            buttonStart.Visible = true;
        }
        // HIT
        private void buttonHit_Click(object sender, EventArgs e)
        {
            if (!jatekFut) return;

            jatek.JatekosHuz();
            FrissitLapok();

            if (jatek.Pontszam(jatek.JatekosKartyak) > 21)
            {
                labelStatusz.Text = "Vesztettél!";
                JatekVege();
            }
        }
        // STAND
        private void buttonStand_Click(object sender, EventArgs e)
        {
            if (!jatekFut) return;
            jatek.DealerHuz();
            FrissitLapok();
            int jatekosPont = jatek.Pontszam(jatek.JatekosKartyak);
            int dealerPont = jatek.Pontszam(jatek.DealerKartyak);

            if (dealerPont > 21 || jatekosPont > dealerPont)
            {
                labelStatusz.Text = "Nyertél!";
                egyenleg += aktualisTet * 2;
            }
            else if (jatekosPont == dealerPont)
            {
                labelStatusz.Text = "Döntetlen!";
                egyenleg += aktualisTet;
            }
            else
            {
                labelStatusz.Text = "Vesztettél!";
            }
            FrissitEgyenleg();
            JatekVege();
        }
        private void JatekVege()
        {
            jatekFut = false;
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
        }
        private void FrissitLapok()
        {
            textBoxKartyak.Text = jatek.KartyakSzoveg(jatek.JatekosKartyak);
            textBoxDealerKartyak.Text = jatek.KartyakSzoveg(jatek.DealerKartyak);
        }
        private void FrissitEgyenleg()
        {
            textBoxEgyenleg.Text = $"{egyenleg} Ft";
            File.WriteAllText("egyenleg.txt", egyenleg.ToString());
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void textBoxDealerKartyak_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void labelStatusz_Click(object sender, EventArgs e) { }

        private void buttonFeltoltes_Click(object sender, EventArgs e)
        {
            int feltoltesOsszeg;

            if (!int.TryParse(textBoxFeltoltes.Text, out feltoltesOsszeg))
            {
                MessageBox.Show("Érvénytelen összeg!", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (feltoltesOsszeg <= 0)
            {
                MessageBox.Show("Pozitív összeget adj meg!", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            egyenleg += feltoltesOsszeg;
            textBoxEgyenleg.Text = $"{egyenleg} Ft";
            File.WriteAllText("egyenleg.txt", egyenleg.ToString());
            textBoxFeltoltes.Clear();
            MessageBox.Show("Sikeres feltöltés!", "Információ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBoxFeltoltes_TextChanged(object sender, EventArgs e) { }
    }
}