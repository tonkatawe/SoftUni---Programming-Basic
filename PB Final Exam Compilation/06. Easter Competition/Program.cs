using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBreads = int.Parse(Console.ReadLine());
            int points = 0;
            int sumPoints = 0;
            int maxPoints = int.MinValue;
            string max = string.Empty;
            for (int i = 0; i < numBreads; i++)
            {
                string name = Console.ReadLine();
                string command = name;


                while (command != "Stop")
                {
                    command = Console.ReadLine();
                    if (command == "Stop")
                    {
                        break;
                    }
                    points = int.Parse(command);
                    sumPoints += points;
                }
                Console.WriteLine($"{name} has {sumPoints} points.");
                if (sumPoints > maxPoints)
                {
                    maxPoints = sumPoints;
                    max = name;
                    Console.WriteLine($"{name} is the new number 1!");
                }
                sumPoints = 0;
            }
            Console.WriteLine($"{max} won competition with {maxPoints} points!");
        }
    }
}

