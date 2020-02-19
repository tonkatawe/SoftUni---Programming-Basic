using System;

namespace _01._Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemonKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            double waterL = double.Parse(Console.ReadLine());
            double lemonJuice = lemonKg * 980;
            double amountMix = lemonJuice + waterL * 1000 + (0.3 * sugarKg);
            double amountCups = Math.Floor(amountMix / 150);
            double profit = amountCups * 1.2;
            Console.WriteLine($"All cups sold: {amountCups}");
            Console.WriteLine($"Money earned: {profit:F2}");
        }
    }
}
