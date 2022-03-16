prawusing System;
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
            try
            {
                double lb1, lb2;
                int choice;
                Console.WriteLine("Lista operacji: ");
                Console.WriteLine("1. + ");
                Console.WriteLine("2. - ");
                Console.WriteLine("3. * ");
                Console.WriteLine("4. / ");
                Console.WriteLine("Wybierz operację: ");
                choice = int.Parse(Console.ReadLine());
                if (choice > 4)
                {
                    Console.WriteLine("Podaj liczbę z zakresu 1-4");
                    Console.Read();
                    Environment.Exit(0);
                }
                Console.WriteLine("Podaj pierwszą liczbę: ");
                lb1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę: ");
                lb2 = Convert.ToDouble(Console.ReadLine());

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
                    if (lb2 == 0)
                    {
                        Console.WriteLine("Próbowałeś podzielić przez 0!");
                        Console.Read();
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Iloraz tych liczb wynosi: " + quot(lb1, lb2));

                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Read();

        }
        public static double suma(double x, double y)
        {
            return x + y;
        }
        public static double diff(double x, double y)
        {
            return x - y;
        }
        public static double prod(double x, double y)
        {
            return x * y;
        }
        public static double quot(double x, double y)
        {
            return x / y;
        }
    }
}
