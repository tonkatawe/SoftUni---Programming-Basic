using System;

namespace _06._Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double points = 0;
            double maxPoint = double.MinValue;
            string winer = string.Empty;

            while (command != "Stop")
            {
                int text = command.Length;
                for (int i = 0; i < command.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    char letter = command[i];
                    if (number == letter)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }

                }
                if (points >= maxPoint)
                {
                    maxPoint = points;
                    winer = command;

                }
                points = 0;
                command = Console.ReadLine();

            }
            Console.WriteLine($"The winner is {winer} with {maxPoint} points!");
        }
    }
}

