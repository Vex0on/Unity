using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_nauka
{
    public class Pracownik
    {
        public string nazwisko;
        private double zarobki;

        public Pracownik(String naz, double zar)
        {
            this.nazwisko = naz;
            this.zarobki = zar;
        }
        public void PokazPracownika()
        {
            Console.WriteLine("{0, -13} {1, 5}", nazwisko, zarobki);
        }
    }


    class Obiektowka
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Malszewski", 2950);
            p1.PokazPracownika();
            Console.ReadKey();
        }
    }
}
