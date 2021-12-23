using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_nauka
{
    class Obliczenia
    {

        static void Main(string[] args)
        {
            int x = 5, y = 10, wynik;
            Console.WriteLine("Liczba x: " + x);
            Console.WriteLine("Liczba y: " + y);
            wynik = 2 * y - 3 * x;
            Console.WriteLine("Wynik dzialania 2*y - 3*x = " + wynik);
            Console.ReadKey();
        }
    }
}
