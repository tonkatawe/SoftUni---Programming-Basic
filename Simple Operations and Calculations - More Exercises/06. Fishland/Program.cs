using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceScumria = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double amountPalamud = double.Parse(Console.ReadLine());
            double amountSafrid = double.Parse(Console.ReadLine());
            int amountMussels = int.Parse(Console.ReadLine());
            double palamudPrice = priceScumria + priceScumria * 0.6;
            double palamudCost = palamudPrice * amountPalamud;
            double priceSafrid = priceCaca + priceCaca * 0.8;
            double safridCost = priceSafrid * amountSafrid;
            double MusselsCost = 7.50 * amountMussels;
            double totalGeorgi = palamudCost + safridCost + MusselsCost;

            Console.WriteLine($"{totalGeorgi:F2}");
        }
    }
}
