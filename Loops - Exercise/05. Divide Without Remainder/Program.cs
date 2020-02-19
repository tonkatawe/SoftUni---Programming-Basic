using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            double n = (double)input;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            double one = p1 / n * 100;
            double two = p2 / n * 100;
            double three = p3 / n * 100;
            Console.WriteLine($"{one:F2}%");
            Console.WriteLine($"{two:F2}%");
            Console.WriteLine($"{three:F2}%");
        }
    }
}
