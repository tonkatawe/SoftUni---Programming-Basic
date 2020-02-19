using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGuest = int.Parse(Console.ReadLine());
            double priceCouvert = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double priceCake = budget * 0.1;
            budget = budget - priceCake;
            if (countGuest >= 10 && countGuest <= 15)
            {
                priceCouvert = priceCouvert * 0.85;
            }
            if (countGuest > 15 && countGuest <= 20)
            {
                priceCouvert = priceCouvert * 0.8;
            }
            if (countGuest > 20)
            {
                priceCouvert = priceCouvert * 0.75;
            }
            double total = priceCouvert * countGuest;
            if (budget >= total)
            {
                double rest = budget - total;
                Console.WriteLine($"It is party time! {rest:F2} leva left.");
            }
            if (total > budget)
            {
                double needed = total - budget;
                Console.WriteLine($"No party! {needed:F2} leva needed.");
            }

        }
    }
}

