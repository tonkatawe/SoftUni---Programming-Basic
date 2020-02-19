using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int playRestDays = restDays * 127;
            int workDays = 365 - restDays;
            int playWorkDays = workDays * 63;
            int timeForPlay = playRestDays + playWorkDays;
            int timeLimit = 30000;
            int hoursPlays = Math.Abs((timeLimit - timeForPlay) / 60);
            int minutesPlays = Math.Abs((timeLimit - timeForPlay) % 60);
            if (timeLimit > timeForPlay)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hoursPlays} hours and {minutesPlays} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hoursPlays} hours and {minutesPlays} minutes more for play");
            }
        }
    }
}
