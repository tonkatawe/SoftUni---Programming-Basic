using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEggs = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxEggs = int.MinValue;
            string max = string.Empty;
            for (int i = 0; i < countEggs; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    redEggs++;
                }
                if (color == "blue")
                {
                    blueEggs++;
                }
                if (color == "orange")
                {
                    orangeEggs++;
                }
                if (color == "green")
                {
                    greenEggs++;

                }
                if (redEggs > maxEggs)
                {
                    maxEggs = redEggs;
                    max = "red";
                }
                if (blueEggs > maxEggs)
                {
                    maxEggs = blueEggs;
                    max = "blue";
                }
                if (orangeEggs > maxEggs)
                {
                    maxEggs = orangeEggs;
                    max = "orange";
                }
                if (greenEggs > maxEggs)
                {
                    maxEggs = greenEggs;
                    max = "green";
                }
            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {max}");
        }
    }
}

