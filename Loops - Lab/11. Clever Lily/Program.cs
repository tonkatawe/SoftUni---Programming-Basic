using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double priceWoshM = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            double savedMoney = 0;
            double moneyBySales = 0;
            int moneyGift = 10;
            for (int i = 1; i <= ageLily; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += moneyGift - 1;
                    moneyGift += 10;
                }
                else
                {
                    moneyBySales += priceToy;
                }
            }
            savedMoney += moneyBySales;
            if (savedMoney >= priceWoshM)
            {
                double rest = savedMoney - priceWoshM;
                Console.WriteLine($"Yes! {rest:F2}");
            }
            else
            {
                double deff = priceWoshM - savedMoney;
                Console.WriteLine($"No! {deff:F2}");
            }
        }
    }
}
