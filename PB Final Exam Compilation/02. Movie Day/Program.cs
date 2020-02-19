using System;

namespace _02._Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieTime = int.Parse(Console.ReadLine());
            int countScenses = int.Parse(Console.ReadLine());
            int timePerScene = int.Parse(Console.ReadLine());
            double preparation = movieTime * 0.15;
            double time = countScenses * timePerScene;
            double needtime = time + preparation;
            if (movieTime > needtime)
            {
                double restTime = movieTime - needtime;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(restTime)} minutes left!");
            }
            else
            {
                double need = needtime - movieTime;
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(need)} minutes.");
            }
        }
    }
}
