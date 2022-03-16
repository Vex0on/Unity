using System;

namespace Cs_nauka
{

    struct Kwadrat
    {
        int bok;
        ConsoleColor kolor;
        public Kwadrat(int bok1, ConsoleColor kolor1)
        {
            bok = bok1;
            kolor = kolor1;
        }
        
        public void RysujKwadrat()
        {
            Console.ForegroundColor = kolor;
            for (int i = 1; i <= bok; i++)
            {
                for (int j = 1; j <= bok; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Struktury
    {
        static void Main(string[] args)
        {
            Kwadrat k1 = new Kwadrat(5, ConsoleColor.Red);
            k1.RysujKwadrat();
            Console.ReadKey();
        }
    }
}
