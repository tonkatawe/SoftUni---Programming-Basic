using System;

namespace _02._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double priceVc = 250 * videoCard;
            double priceProcessors = (priceVc * 0.35) * processors;
            double priceRam = (priceVc * 0.1) * ram;
            double sum = priceVc + priceProcessors + priceRam;
            if (videoCard > processors)
            {
                sum = sum - sum * 0.15;
            }
            if (budget >= sum)
            {
                double rest = budget - sum;
                Console.WriteLine($"You have {rest:F2} leva left!");
            }
            else
            {
                double need = sum - budget;
                Console.WriteLine($"Not enough money! You need {need:F2} leva more!");

            }
        }
    }
}

