using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryKektura
{
    public class kektura
    {
        public string kiinduloPont { get; private set; }
        public string vegPont { get; private set; }
        public double szakaszHosszKm { get; private set; }
        public int emelkedes { get; private set; }
        public int lejtes { get; private set; }
        public bool pecseteloHely { get; private set; }
        public static int kezdoMagassag { get; private set; }
        public static List<kektura> kekturaLista = new List<kektura>();

        public kektura(string sor)
        {
            string[] db = sor.Split(';');
            this.kiinduloPont = db[0];
            this.vegPont = db[1];
            this.szakaszHosszKm = double.Parse(db[2]);
            this.emelkedes = int.Parse(db[3]);
            this.lejtes = int.Parse(db[4]);
            if (db[5] == "i")
            {
                this.pecseteloHely = true;
            }
            else
            {
                this.pecseteloHely = false;
            }
        }
        public static List<kektura> FileBeolvasas(string filenev)
        {
            try
            {
                StreamReader sr = new StreamReader(filenev);
                kezdoMagassag = int.Parse(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    var obj = new kektura(sr.ReadLine());
                    kekturaLista.Add(obj);
                }
                sr.Close();
            }
            catch
            {
                throw new Exception("Hiba a fájl megnyitása során");
            }
        return kekturaLista;
        }
    }
}
