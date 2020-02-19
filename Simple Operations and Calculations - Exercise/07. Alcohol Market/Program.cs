using System;

namespace _07._Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double countBeer = double.Parse(Console.ReadLine());
            double countWine = double.Parse(Console.ReadLine());
            double countRakia = double.Parse(Console.ReadLine());
            double countWiskey = double.Parse(Console.ReadLine());
            double rakiaPrice = wiskeyPrice / 2;
            double winePrice = rakiaPrice - rakiaPrice * 0.4;
            double beerPrice = rakiaPrice - rakiaPrice * 0.8;
            double sumforAlcholo = (countBeer * beerPrice) + (countRakia * rakiaPrice) + (countWine * winePrice) + (countWiskey * wiskeyPrice);

            Console.WriteLine($"{sumforAlcholo:F2}");
        }
    }
}