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

    internal class Program
    {
        static void Main(string[] args)
        {
            Termek a = new Termek("sajt", 1000);
            a.Info();
        }
    }
}
