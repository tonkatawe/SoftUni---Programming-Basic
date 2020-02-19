using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;

            }
            double average = sum / n;
            Console.WriteLine($"{average:F2}");
        }
    }
}
