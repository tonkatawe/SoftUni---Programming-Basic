using System;

namespace _03._Luggage_Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            int wideCase = int.Parse(Console.ReadLine());
            int hightCase = int.Parse(Console.ReadLine());
            int deepCase = int.Parse(Console.ReadLine());
            string typeCase = Console.ReadLine();
            int volumeCase = wideCase * hightCase * deepCase;
            double tax = 0;

            if (typeCase == "true")
            {
                if (volumeCase >= 50 && volumeCase <= 100)
                {
                    tax = 0;
                }
                if (volumeCase > 100 && volumeCase <= 200)
                {
                    tax = 10;
                }
                if (volumeCase > 200 && volumeCase <= 300)
                {
                    tax = 20;
                }

            }
            if (typeCase == "false")
            {
                if (volumeCase >= 50 && volumeCase <= 100)
                {
                    tax = 25;
                }
                if (volumeCase > 100 && volumeCase <= 200)
                {
                    tax = 50;
                }
                if (volumeCase > 200 && volumeCase <= 300)
                {
                    tax = 100;
                }

            }
            Console.WriteLine($"Luggage tax: {tax:F2}");

        }
    }
}

