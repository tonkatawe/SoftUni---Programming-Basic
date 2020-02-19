using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            double priceTowel = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double priceUmbrela = (priceTowel / 3) * 2;
            double priceFlipFlops = priceUmbrela * 0.75;
            double priceBag = (priceTowel + priceFlipFlops) / 3;
            double allPrice = priceFlipFlops + priceBag + priceTowel + priceUmbrela;
            double allWithDiscount = allPrice - (allPrice * discount) / 100;
            if (buget >= allWithDiscount)
            {
                double rest = buget - allWithDiscount;
                Console.WriteLine($"Annie's sum is {allWithDiscount:F2} lv. She has {rest:F2} lv. left.");
            }
            else
            {
                double needs = allWithDiscount - buget;
                Console.WriteLine($"Annie's sum is {allWithDiscount:F2} lv. She needs {needs:f2} lv. more.");
            }
        }
    }
}
