namespace ClassLibrarySzoba
{
    public class Szoba
    {
        public double Hosszusag { get; set; }
        public double Szelesseg { get; set; }
        public double Magassag { get; set; }
        public Szoba(double h, double sz, double m)
        {
            this.Hosszusag = h;
            this.Szelesseg = sz;
            this.Magassag = m;
        }
        public double Alapterulet()
        {
            return Math.Round(this.Hosszusag * this.Szelesseg, 2);
        }
        public double Terfogat()
        {
            return Math.Round(this.Hosszusag * this.Szelesseg * this.Magassag, 2);
        }
        public double FalFelulet()
        {
            double hosszuOldal = this.Hosszusag * this.Magassag * 2;
            double rovidOldal = this.Szelesseg * this.Magassag * 2;
            double plafon = Alapterulet();
            return Math.Round(hosszuOldal + rovidOldal + plafon, 2);
        }
    }
}
