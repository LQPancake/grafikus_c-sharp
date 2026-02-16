using ClassLibraryKektura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kekturaForm
{
    public partial class Form1 : Form
    {
        private static List<Kektura> lathatoLista = new List<Kektura>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Kektura.FileBeolvasas("kektura.csv");
                TeljesListaMasolat();
                ListaMegjelenites();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TeljesListaMasolat()
        {
            lathatoLista.Clear();
            foreach (var obj in Kektura.KekturaLista)
            {
                lathatoLista.Add(obj);
            }
        }

        private void ListaMegjelenites()
        {
            listBoxUtvonalLista.Items.Clear();
            foreach (var obj in lathatoLista)
            {
                listBoxUtvonalLista.Items.Add(obj.KiinduloPont);
            }
            labelSorokSzama.Text=lathatoLista.Count.ToString() + " db";
        }

        private void buttonAdatokMegjelenitese_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxUtvonalLista.SelectedItem == null)
                {
                    MessageBox.Show("Válasszon ki egy elemet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int index = listBoxUtvonalLista.SelectedIndex;

                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == null) {return;}
            else
            {
                string darab = textBoxSearch.Text;
                foreach(var obj in Kektura.KekturaLista)
                {
                    if(obj.KiinduloPont.Contains(darab))
                    {
                        lathatoLista.Add(obj);
                    }
                }
                ListaMegjelenites();
            }
        }
    }
}
