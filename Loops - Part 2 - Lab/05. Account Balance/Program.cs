using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int counter = 1;
            double balance = 0;
            while (counter <= num)
            {
                double sum = double.Parse(Console.ReadLine());
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                counter++;
                Console.WriteLine($"Increase: {sum:F2}");

                balance = balance + sum;
            }
            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}

