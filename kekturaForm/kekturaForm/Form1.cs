using ClassLibraryKektura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kekturaForm;

namespace kekturaForm
{
    public partial class Form1 : Form
    {
        private static List<kektura> lathatoLista = new List<kektura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                kektura.FileBeolvasas("kektura.csv");
                teljesListaMasolat();
                listaMegjelenites();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a fájl beolvasásakor!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxUtvonalLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void teljesListaMasolat()
        {
            foreach (var obj in kektura.kekturaLista)
            {
                lathatoLista.Add(obj);
            }
        }
        private void listaMegjelenites()
        {
            listBoxUtvonalLista.Items.Clear();
            foreach (var obj in lathatoLista)
            {
                listBoxUtvonalLista.Items.Add(obj.kiinduloPont);
            }
        }

        private void labelDarabszam_Click(object sender, EventArgs e)
        {
            foreach (var obj in lathatoLista)
            {
                labelDarabszam.Text = lathatoLista.Count + "Db";
            }
        }

        private void buttonAdatok_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxUtvonalLista.SelectedItem;
            }
        }
    }
}
