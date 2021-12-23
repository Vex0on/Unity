using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_nauka
{
    public class Pracownik
    {
        public static int liczbaPrac;
        public string nazwisko { get; set; }
        private double zarobki { get; set; }

        public Pracownik(String naz, double zar)
        {
            liczbaPrac++;
            this.nazwisko = naz;
            this.zarobki = zar;
        }

        static Pracownik()
        {
            liczbaPrac = 0;
        }
        public void PokazPracownika()
        {
            Console.WriteLine("{0, -13} {1, 5}", nazwisko, zarobki);
        }

        public static double SumaZarobkow(Pracownik[] tab)
        {
            double suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i].zarobki;
            }
            return suma;
        }
    }


    class Obiektowka
    {
        static void Main(string[] args)
        {
            Pracownik[] robota = new Pracownik[4];
            robota[0] = new Pracownik("Malszewski", 2950.0);
            robota[1] = new Pracownik("Kowalski", 3220.0);
            robota[2] = new Pracownik("Wegierski", 2560.0);
            robota[3] = new Pracownik("Olinowska", 3150.0);

            foreach (Pracownik p in robota)
            {
                p.PokazPracownika();
            }

            Console.WriteLine();
            Console.WriteLine("Liczba Prac: {0}", Pracownik.liczbaPrac);
            Console.WriteLine("Suma Zarobkow: {0}", Pracownik.SumaZarobkow(robota));
            Console.ReadKey();
        }
    }
}
