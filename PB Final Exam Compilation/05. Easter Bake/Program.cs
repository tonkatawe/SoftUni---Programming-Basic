using System;

namespace _05._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int breads = int.Parse(Console.ReadLine());
            int suggar = 0;
            int flour = 0;
            double sumSugar = 0;
            double sumFlour = 0;
            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;
            for (int i = 0; i < breads; i++)
            {
                suggar = int.Parse(Console.ReadLine());
                flour = int.Parse(Console.ReadLine());
                if (suggar > maxSugar)
                {
                    maxSugar = suggar;
                }
                if (flour > maxFlour)
                {
                    maxFlour = flour;
                }
                sumFlour += flour;
                sumSugar += suggar;

            }
            double packetsSugar = Math.Ceiling(sumSugar / 950);
            double packetsFlour = Math.Ceiling(sumFlour / 750);
            Console.WriteLine($"Sugar: {packetsSugar}");
            Console.WriteLine($"Flour: {packetsFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}

