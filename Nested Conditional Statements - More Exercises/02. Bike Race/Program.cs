using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double countJuniors = double.Parse(Console.ReadLine());
            double countSeniors = double.Parse(Console.ReadLine());
            string typeOfRace = Console.ReadLine();
            double sumJuniors = 0;
            double sumSeniors = 0;
            double sumTogether = 0;
            double totalSUm = 0;
            if (typeOfRace == "trail" && (countSeniors + countJuniors) > 0)
            {

                sumJuniors = countJuniors * 5.5;
                sumSeniors = countSeniors * 7;
                sumTogether = sumSeniors + sumJuniors;
                totalSUm = sumTogether - sumTogether * 0.05;
            }
            if (typeOfRace == "cross-country" && (countSeniors + countJuniors) > 0)
            {

                sumJuniors = countJuniors * 8;
                sumSeniors = countSeniors * 9.5;
                sumTogether = sumSeniors + sumJuniors;
                totalSUm = sumTogether - sumTogether * 0.05;
                if ((countSeniors + countJuniors) >= 50)
                {
                    sumTogether = (countSeniors * 9.5 + countJuniors * 8) - ((countSeniors * 9.5) * 0.25 + ((countJuniors * 8) * 0.25));
                    totalSUm = sumTogether - sumTogether * 0.05;
                }

            }

            if (typeOfRace == "downhill" && (countSeniors + countJuniors) > 0)
            {

                sumJuniors = countJuniors * 12.25;
                sumSeniors = countSeniors * 13.75;
                sumTogether = sumSeniors + sumJuniors;
                totalSUm = sumTogether - sumTogether * 0.05;
            }
            if (typeOfRace == "road" && (countSeniors + countJuniors) > 0)
            {

                sumJuniors = countJuniors * 20;
                sumSeniors = countSeniors * 21.50;
                sumTogether = sumSeniors + sumJuniors;
                totalSUm = sumTogether - sumTogether * 0.05;
            }
            if (countJuniors > 0 || countSeniors > 0)
            {
                Console.WriteLine($"{totalSUm:F2}");
            }
        }

    }
}

