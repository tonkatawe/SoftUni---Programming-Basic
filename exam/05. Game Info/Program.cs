using System;

namespace _05._Game_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamNeam = Console.ReadLine();
            double countGames = double.Parse(Console.ReadLine());
            int additional = 0;
            int penalties = 0;
            int sum = 0;
            for (int i = 0; i < countGames; i++)
            {
                int duration = int.Parse(Console.ReadLine());
                sum += duration;
                if (duration > 90 && duration <= 120)
                {
                    additional++;
                }
                if (duration > 120)
                {
                    penalties++;
                }

            }
            double averrage = sum / countGames;
            Console.WriteLine($"{teamNeam} has played {sum} minutes. Average minutes per game: {averrage:F2}");
            Console.WriteLine($"Games with penalties: {penalties}");
            Console.WriteLine($"Games with additional time: {additional}");
        }
    }
}
