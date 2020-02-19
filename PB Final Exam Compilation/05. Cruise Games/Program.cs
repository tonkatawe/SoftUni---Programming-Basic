using System;

namespace _05._Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            double gamesPoints = 0;
            double allPoints = 0;
            double pointsVolley = 0;
            double pointsTennis = 0;
            double pointsBadminton = 0;
            int counterVolley = 0;
            int counterTennis = 0;
            int counterBadminton = 0;
            for (int i = 0; i < games; i++)
            {
                string nameOfGames = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());
                if (nameOfGames == "volleyball")
                {
                    pointsVolley += points + points * 0.07;
                    counterVolley++;
                }
                if (nameOfGames == "tennis")
                {
                    pointsTennis += points + points * 0.05;
                    counterTennis++;
                }
                if (nameOfGames == "badminton")
                {
                    pointsBadminton += points + points * 0.02;
                    counterBadminton++;
                }

            }
            double volleyAv = Math.Floor(pointsVolley / counterVolley);
            double tenisAv = Math.Floor(pointsTennis / counterTennis);
            double badminAv = Math.Floor(pointsBadminton / counterBadminton);
            allPoints = pointsBadminton + pointsTennis + pointsVolley;
            if (volleyAv >= 75 && tenisAv >= 75 && badminAv >= 75)
            {
                Console.WriteLine($"Congratulations, {playerName}! You won the cruise games with {Math.Floor(allPoints)} points.");

            }
            else
            {
                Console.WriteLine($"Sorry, {playerName}, you lost. Your points are only {Math.Floor(allPoints)}.");
            }
        }
    }
}

