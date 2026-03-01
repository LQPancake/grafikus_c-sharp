using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackLibrary
{
    public class BlackjackGame
    {
        private List<string> pakli;
        private Random random = new Random();

        public List<string> JatekosKartyak { get; private set; }
        public List<string> DealerKartyak { get; private set; }

        public BlackjackGame()
        {
            UjJatek();
        }
        public void UjJatek()
        {
            pakli = new List<string>()
            {
                "1","2","3","4","5","6","7","8","9",
                "J","Q","K","A"
            };

            JatekosKartyak = new List<string>();
            DealerKartyak = new List<string>();

            // Kezdő lapok
            HuzLap(JatekosKartyak);
            HuzLap(JatekosKartyak);
            HuzLap(DealerKartyak);
            HuzLap(DealerKartyak);
        }

        public void JatekosHuz()
        {
            HuzLap(JatekosKartyak);
        }

        public void DealerHuz()
        {
            while (Pontszam(DealerKartyak) < 17)
            {
                HuzLap(DealerKartyak);
            }
        }

        private void HuzLap(List<string> kez)
        {
            int index = random.Next(pakli.Count);
            kez.Add(pakli[index]);
        }

        public int Pontszam(List<string> kez)
        {
            int osszeg = 0;

            foreach (var lap in kez)
            {
                if (lap == "J" || lap == "Q" || lap == "K")
                    osszeg += 10;
                else if (lap == "A")
                    osszeg += 11;
                else
                    osszeg += int.Parse(lap);
            }

            return osszeg;
        }

        public string KartyakSzoveg(List<string> kez)
        {
            return string.Join(", ", kez);
        }
    }
}