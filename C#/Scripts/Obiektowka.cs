using System;

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
        public override string ToString()
        {
            return String.Format("{0, -13} {1, 5}zł", nazwisko, zarobki);
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
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Liczba Prac: {0}", Pracownik.liczbaPrac);
            Console.WriteLine("Suma Zarobkow: {0}", Pracownik.SumaZarobkow(robota));
            Console.ReadKey();
        }
    }
}
