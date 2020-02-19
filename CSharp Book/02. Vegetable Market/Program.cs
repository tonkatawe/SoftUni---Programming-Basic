using System;

namespace _02._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int amountVegetables = int.Parse(Console.ReadLine());
            int amountFruits = int.Parse(Console.ReadLine());
            double amountPriceVegatables = priceVegetables * amountVegetables;
            double amountPriceFruits = priceFruits * amountFruits;
            double total = (amountPriceFruits + amountPriceVegatables) / 1.94;
            Console.WriteLine(total);
        }
    }
}
