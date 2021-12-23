using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_nauka
{
    class Matma
    {
        static void Main(String[] args)
        {
            double x, y;
            Console.WriteLine("Podaj x > 0: ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
