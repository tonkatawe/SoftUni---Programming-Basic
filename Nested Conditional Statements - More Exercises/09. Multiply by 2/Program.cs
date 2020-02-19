using System;

namespace _09._Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (number >= 0)
            {

                number = number * 2;
                Console.WriteLine($"Result: {number:F2}");
                number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                }
            }

        }
    }
}