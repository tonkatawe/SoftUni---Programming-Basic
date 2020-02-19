using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            double n = (double)input;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                if (num >= 800)
                {
                    p5++;
                }
            }
            double one = p1 / n * 100;
            double two = p2 / n * 100;
            double three = p3 / n * 100;
            double four = p4 / n * 100;
            double five = p5 / n * 100;
            Console.WriteLine($"{one:F2}%");
            Console.WriteLine($"{two:F2}%");
            Console.WriteLine($"{three:F2}%");
            Console.WriteLine($"{four:F2}%");
            Console.WriteLine($"{five:F2}%");
        }
    }
}
