using System;

namespace _04._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPoint = int.Parse(Console.ReadLine());
            string text = string.Empty;
            int points = 0;
            int gamePoints = 0;
            int restPoint = firstPoint;
            int counter = 0;

            while (text != "bullseye" && restPoint > 0)
            {
                counter++;
                text = Console.ReadLine();
                if (text == "bullseye")
                {
                    break;
                }
                points = int.Parse(Console.ReadLine());
                if (text == "double ring")
                {
                    gamePoints = points * 2;

                }
                if (text == "triple ring")
                {
                    gamePoints = points * 3;
                }
                if (text == "number section")
                {

                    gamePoints = points;
                }
                restPoint -= gamePoints;
                if (restPoint == 0)
                {
                    break;
                }

            }
            if (restPoint == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {counter} moves!");
            }
            if (text == "bullseye")
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
            }
            if (restPoint < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(restPoint)}.");
            }
        }
    }
}

