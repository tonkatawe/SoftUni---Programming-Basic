using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double extras = double.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());
            double decorPrice = budget * 0.1;
            double sumClothes = extras * priceClothes;
            double sumFilms = sumClothes + decorPrice;
            if (budget >= sumFilms && extras < 150)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - sumFilms):F2} leva left.");
            }

            else if (extras >= 150 && budget >= sumFilms)
            {
                sumClothes -= sumClothes * 0.1;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - decorPrice - sumClothes):F2} leva left.");
            }
            else if (budget <= sumFilms && extras >= 150)
            {
                sumClothes -= sumClothes * 0.1;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - decorPrice - sumClothes):F2} leva more.");
            }
            else if (budget <= sumFilms && extras < 150)
            {

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - decorPrice - sumClothes):F2} leva more.");
            }
        }
    }
}
