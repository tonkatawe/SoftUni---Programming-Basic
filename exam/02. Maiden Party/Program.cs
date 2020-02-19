using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceParty = double.Parse(Console.ReadLine());
            double loveLetters = double.Parse(Console.ReadLine());
            double countWaxRosses = double.Parse(Console.ReadLine());
            double keychains = double.Parse(Console.ReadLine());
            double pictures = double.Parse(Console.ReadLine());
            double luckySurprise = double.Parse(Console.ReadLine());
            double total = loveLetters * 0.6 + countWaxRosses * 7.2 + keychains * 3.6 + pictures * 18.2 + luckySurprise * 22;
            double items =  loveLetters + countWaxRosses + keychains + pictures + luckySurprise;
            if (items >25)
            {
                total -= total * 0.35;
            }
            total -= total * 0.1;
            if (total >= priceParty)
            {
                double rest = total - priceParty;
                Console.WriteLine($"Yes! {rest:F2} lv left.");
            }
            if (priceParty > total)
            {
                double needed = priceParty - total;
                Console.WriteLine($"Not enough money! {needed:F2} lv needed.");
            }
        }
    }
}
