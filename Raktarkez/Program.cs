namespace Raktarkez
{
    public class Termek
    {
        protected string nev;
        private int ar;

        public Termek(string nev, int ar)
        {
            this.nev = nev;
            this.ar = ar;
        }
        public void Info()
        {
            Console.WriteLine($"A termék neve: {nev}; ára: {ar} Ft");
        }
    }

    public class Elelmiszer : Termek
    {
        private int lejaratiSzam;
        public Elelmiszer(string nev, int ar, int lejaratiSzam) : base(nev, ar)
        {
            this.lejaratiSzam = lejaratiSzam;
        }
        public void LejartE()
        {
            if (lejaratiSzam < 10)
                Console.WriteLine("Lejárt a termék");
        }
    }

  
    internal class Program
    {
        static void Main(string[] args)
        {
            Termek a = new Termek("sajt", 1000);
            a.Info();
            Elelmiszer e = new Elelmiszer("tej", 300, 8);
            e.Info();
            e.LejartE();
        }
    }
}
