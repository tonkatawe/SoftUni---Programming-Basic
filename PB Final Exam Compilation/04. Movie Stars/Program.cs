using System;

namespace _04._Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double budget2 = budget;
            string name = string.Empty;
            double salary = 0;
            double honurar = 0;
            double sum = 0;

            while (command != "ACTION")
            {
                int lenght = command.Length;
                if (lenght > 15)
                {
                    salary = budget * 0.2;
                    budget -= salary;
                    sum += salary;
                    command = Console.ReadLine();
                }
                honurar = double.Parse(Console.ReadLine());
                budget -= honurar;
                sum += honurar;
                if (budget < 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (budget < 0)
            {
                Console.WriteLine($"We need {(sum - budget2):F2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {(budget2 - sum):F2} leva.");
            }
        }
    }
}

