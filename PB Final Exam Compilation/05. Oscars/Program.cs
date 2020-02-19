using System;

namespace _05._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            double judge = double.Parse(Console.ReadLine());
            string umpire = string.Empty;
            double pointByUmpire = 0;
            double points = pointsAcademy;
            for (int i = 0; i < judge; i++)
            {
                umpire = Console.ReadLine();
                pointByUmpire = double.Parse(Console.ReadLine());
                int lenght = umpire.Length;
                points += (lenght * pointByUmpire) / 2;
                if (points >= 1250.5)
                {
                    break;
                }

            }
            if (points >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:F1}!");
            }
            else
            {
                double needed = 1250.5 - points;
                Console.WriteLine($"Sorry, {name} you need {needed:F1} more!");
            }
        }
    }
}
