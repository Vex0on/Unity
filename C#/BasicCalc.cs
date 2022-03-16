using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ckratka
{
    class BasicCalc
    {
        static void Main(string[] args)
        {
            int lb1, lb2, choice;
            Console.WriteLine("Lista operacji: ");
            Console.WriteLine("1. + ");
            Console.WriteLine("2. - ");
            Console.WriteLine("3. * ");
            Console.WriteLine("4. / ");
            Console.WriteLine("Wybierz operację: ");
            choice = int.Parse(Console.ReadLine());
            if(choice > 4)
            {
                Console.WriteLine("Podaj liczbę z zakresu 1-4");
                Console.Read();
                Environment.Exit(0);
            }
            Console.WriteLine("Podaj pierwszą liczbę: ");
            lb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            lb2 = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Suma tych liczb wynosi: " + suma(lb1, lb2));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Różnica tych liczb wynosi: " + diff(lb1, lb2));

            }
            else if (choice == 3)
            {
                Console.WriteLine("Iloczyn tych liczb wynosi: " + prod(lb1, lb2));

            }
            else if (choice == 4)
            {
                Console.WriteLine("Iloraz tych liczb wynosi: " + quot(lb1, lb2));

            }


            Console.Read();

        }
        public static int suma(int x, int y)
        {
            return x + y;
        }
        public static int diff(int x, int y)
        {
            return x - y;
        }
        public static int prod(int x, int y)
        {
            return x * y;
        }
        public static int quot(int x, int y)
        {
            return x / y;
        }
    }
}
