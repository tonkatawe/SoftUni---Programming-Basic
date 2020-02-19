using System;

namespace _06._Movie_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int sym1 = a1; sym1 <= a2 - 1; sym1++)
            {
                for (int sym2 = 1; sym2 <= n - 1; sym2++)
                {
                    for (int sym3 = 1; sym3 <= n / 2 - 1; sym3++)
                    {
                        int sym4 = (char)sym1;
                        if (sym1 % 2 != 0 && (sym2 + sym3 + sym4) % 2 != 0)
                        {
                            Console.Write($"{(char)sym1}-{sym2}{sym3}{sym4}");
                            Console.WriteLine();
                        }

                    }
                }
            }
        }
    }
}
