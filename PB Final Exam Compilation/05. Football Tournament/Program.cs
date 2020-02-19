using System;

namespace _05._Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamNeam = Console.ReadLine();
            int amountMatch = int.Parse(Console.ReadLine());
            int points = 0;
            int winGames = 0;
            int equalGames = 0;
            int lostGames = 0;
            double winRate = 0;
            double counter = 0;

            for (int i = 0; i < amountMatch; i++)
            {
                char results = char.Parse(Console.ReadLine());
                if (results == 'W')
                {
                    points += 3;
                    winGames++;
                }
                if (results == 'D')
                {
                    points += 1;
                    equalGames++;
                }
                if (results == 'L')
                {
                    points += 0;
                    lostGames++;
                }
                counter++;

            }
            if (amountMatch == 0)
            {
                Console.WriteLine($"{teamNeam} hasn't played any games during this season.");
            }
            else
            {
                winRate = (winGames / counter) * 100;
                Console.WriteLine($"{teamNeam} has won {points} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {winGames}");
                Console.WriteLine($"## D: {equalGames}");
                Console.WriteLine($"## L: {lostGames}");
                Console.WriteLine($"Win rate: {winRate:F2}%");
            }
        }

    }
}
