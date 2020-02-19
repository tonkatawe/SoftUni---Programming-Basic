using System;

namespace _05._Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double countSeries = double.Parse(Console.ReadLine());
            double price = 0;
            double sum = 0;
            for (int i = 0; i < countSeries; i++)
            {
                string nameSerials = Console.ReadLine();
                double pricePerSerials = double.Parse(Console.ReadLine());
                if (nameSerials == "Thrones")
                {
                    price = pricePerSerials * 0.5;
                    //sum += price;
                }
                else if (nameSerials == "Lucifer")
                {
                    price = pricePerSerials - pricePerSerials * 0.4;
                    //sum += price;
                }
                else if (nameSerials == "Protector")
                {
                    price = pricePerSerials - pricePerSerials * 0.3;
                    //sum += price;
                }
                else if (nameSerials == "TotalDrama")
                {
                    price = pricePerSerials - pricePerSerials * 0.2;
                    //sum += price;
                }
                else if (nameSerials == "Area")
                {
                    price = pricePerSerials - pricePerSerials * 0.1;
                    //sum += price;
                }
                else
                {
                    price = pricePerSerials;
                }
                sum += price;
            }
            if (budget >= sum)
            {
                double rest = budget - sum;
                Console.WriteLine($"You bought all the series and left with {rest:F2} lv.");
            }
            else
            {
                double needed = sum - budget;
                Console.WriteLine($"You need {needed:F2} lv. more to buy the series!");
            }
        }
    }
}

