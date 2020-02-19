using System;

namespace _01._Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int session = int.Parse(Console.ReadLine());
            int serias = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double adverts = time * 0.2;
            double timeWithAd = time + adverts;
            double bonusScenes = session * 10;
            double total = Math.Floor(timeWithAd * session * serias + bonusScenes);
            Console.WriteLine($"Total time needed to watch the {serialName} series is {total} minutes.");

        }
    }
}

