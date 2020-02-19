using System;

namespace PB_Online_Exam___2_and_3_November_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double countWater = double.Parse(Console.ReadLine());
            double countWine = double.Parse(Console.ReadLine());
            double countShampine = double.Parse(Console.ReadLine());
            double countWiskey = double.Parse(Console.ReadLine());
            double priceShampine = wiskeyPrice * 0.5;
            double priceWine = priceShampine * 0.4;
            double priceWater = priceShampine * 0.1;
            double total = wiskeyPrice * countWiskey + countWater * priceWater + countShampine * priceShampine + countWine*priceWine;
            Console.WriteLine($"{total:F2}");
        }
    }
}
