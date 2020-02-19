using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            if (nights > 7)
            {
                priceNight -= priceNight * 0.05;
            }
            double otherCosts = double.Parse(Console.ReadLine());
            double price = priceNight * nights;
            double costs = (otherCosts * budget) / 100;
            double total = price + costs;
            if (total <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {(budget - total):F2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{(total - budget):F2} leva needed.");
            }
        }
    }
}
