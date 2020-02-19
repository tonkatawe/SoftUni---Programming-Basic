using System;

namespace _01._Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourCount = double.Parse(Console.ReadLine());
            double sugarCount = double.Parse(Console.ReadLine());
            double eggsCount = double.Parse(Console.ReadLine());
            double yeastPackets = double.Parse(Console.ReadLine());
            double sugarPrice = flourPrice * .75;
            double eggPrice = flourPrice * 1.1;
            double yeastPrice = sugarPrice * 0.2;
            double total = flourPrice * flourCount + sugarPrice * sugarCount + eggPrice * eggsCount + yeastPackets * yeastPrice;
            Console.WriteLine($"{total:F2}");
        }
    }
}
