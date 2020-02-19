using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string outInput = Console.ReadLine();
            if (input == "mm" && outInput == "m")
            {
                Console.WriteLine($"{ (number / 1000):F3}");

            }
            else if (input == "m" && outInput == "cm")
            {
                Console.WriteLine($"{(number * 100):F3}");
            }
            else if (input == "cm" && outInput == "mm")
            {
                Console.WriteLine($"{(number * 10):F3}");
            }
            else if (input == "mm" && outInput == "cm")
            {
                Console.WriteLine($"{(number / 10):F3}");
            }
            else if (input == "cm" && outInput == "m")
            {
                Console.WriteLine($"{(number / 100):F3}");
            }
            else if (input == "m" && outInput == "cm")
            {
                Console.WriteLine($"{(number * 1000):F3}");
            }
            else if (input == "m" && outInput == "mm")
            {
                Console.WriteLine($"{(number * 1000):F3}");
            }
        }
    }
}
