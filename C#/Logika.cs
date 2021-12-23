using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_nauka
{
    class Logika
    {
        static void Main(String[] args) 
        {
            double wiek, kasa;
            bool CzyMogeOgladac;
            Console.WriteLine("Ile masz lat?");
            wiek = double.Parse(Console.ReadLine());
            Console.WriteLine("Ile masz pieniedzy?");
            kasa = double.Parse(Console.ReadLine());
            CzyMogeOgladac = (wiek >= 18 && kasa >= 20);
            Console.WriteLine(CzyMogeOgladac);
            Console.ReadKey();
        }
    }
}
