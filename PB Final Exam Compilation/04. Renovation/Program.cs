using System;

namespace _04._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int noPaint = int.Parse(Console.ReadLine());
            int paint = 0;
            double paintArea = Math.Ceiling(height * widht * 4 - ((height * widht * 4) * noPaint) / 100);
            double rest = paintArea;
            string command = Console.ReadLine();
            while (command != "Tired!")
            {
                paint = int.Parse(command);
                rest -= paint;
                if (rest < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(rest)} l paint left!");
                    return;
                }
                if (rest == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                }
                command = Console.ReadLine();

            }
            if (rest < paintArea)
            {
                Console.WriteLine($"{rest} quadratic m left.");
            }

        }
    }
}

