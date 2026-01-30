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
        public bool LejartE()
        {
            if (lejaratiSzam < 10)
            {
                Console.WriteLine("Lejárt a termék");
                return false;
            }
            return true;
        }
    }
    public class Raktar
    {
        private List<Termek> keszlet;

        public Raktar()
        {
            keszlet = new List<Termek>();
        }

        public void Hozzaad(Termek t)
        {
            if(t is Elelmiszer)
                if(((Elelmiszer)t).LejartE())
                    keszlet.Add(t);
        }
        public void Listazz()
        {
            foreach (Termek t in keszlet)
            {
                t.Info();
            }
        }

        public void ElelmiszerekListazasa()
        {
            foreach (Termek t in keszlet)
            {
                if (t is Elelmiszer)
                {
                    t.Info();
                }
            }
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
            Raktar raktar = new Raktar();
            raktar.Hozzaad(new Elelmiszer("kifli", 200, 60));
            raktar.Hozzaad(new Elelmiszer("zsömle", 100, 67));
            raktar.Hozzaad(a);
            raktar.Listazz();
            Console.WriteLine("------");
            raktar.ElelmiszerekListazasa();
        }
    }
}
