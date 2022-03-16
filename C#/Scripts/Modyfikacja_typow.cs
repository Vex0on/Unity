using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_nauka
{
    class Modyfikacja_typow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zamiana ze stopni Fahrenheita na Celsjusza ");
            Console.ReadKey();
            double Fahr, Cels;
            Console.WriteLine("Podaj temp. w stopniach Fahrenheita: ");
            Fahr = double.Parse(Console.ReadLine());
            Cels = 5D / 9 * (Fahr - 32);
            Console.WriteLine(Cels);
            Console.ReadKey();
        }
    }
}
