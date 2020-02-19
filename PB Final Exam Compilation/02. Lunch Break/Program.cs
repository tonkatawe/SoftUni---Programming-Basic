using System;

namespace _02._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            double duration = double.Parse(Console.ReadLine());
            double restDuration = double.Parse(Console.ReadLine());
            double lunchTime = restDuration / 8;
            double rest = restDuration / 4;
            double restAndLunch = lunchTime + rest;
            double restTime = restDuration - rest - lunchTime;
            if (restTime >= duration)
            {
                double moreTime = Math.Ceiling(restTime - duration);
                Console.WriteLine($"You have enough time to watch {serialName} and left with {moreTime} minutes free time.");
            }
            else
            {
                double needed = Math.Ceiling(duration - restTime);
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {needed} more minutes.");
            }
        }
    }
}

