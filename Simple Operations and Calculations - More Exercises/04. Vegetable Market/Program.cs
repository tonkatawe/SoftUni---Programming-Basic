using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVegetables = double.Parse(Console.ReadLine());
            double pricePerKgFruits = double.Parse(Console.ReadLine());
            double amountVegetables = double.Parse(Console.ReadLine());
            double amountFruits = double.Parse(Console.ReadLine());
            double totalPriceVegetables = pricePerKgVegetables * amountVegetables;
            double VegetableInEuro = totalPriceVegetables;
            double totalPriceFruits = pricePerKgFruits * amountFruits;
            double FruitsInEuro = totalPriceFruits;
            double totalInEuro = (VegetableInEuro + FruitsInEuro) / 1.94;
            Console.WriteLine($"{totalInEuro:F2}");
        }
    }
}