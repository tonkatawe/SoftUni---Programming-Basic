using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;

            if (destination == "Dubai")
            {
                if (season == "Summer")
                {
                    price = (days * 40000) - (days * 40000) * 0.3;
                }
                if (season == "Winter")
                {
                    price = (days * 45000) - (days * 45000) * 0.3;
                }
            }
            if (destination == "Sofia")
            {
                if (season == "Summer")
                {
                    price = (days * 12500) + (days * 12500) * 0.25;
                }
                if (season == "Winter")
                {
                    price = (days * 17000) + (days * 17000) * 0.25;
                }
            }
            if (destination == "London")
            {
                if (season == "Summer")
                {
                    price = days * 20250;
                }
                if (season == "Winter")
                {
                    price = days * 24000;
                }
            }
            if (budget >= price)
            {
                double rest = budget - price;
                Console.WriteLine($"The budget for the movie is enough! We have {rest:F2} leva left!");
            }
            else
            {
                double need = price - budget;
                Console.WriteLine($"The director needs {need:F2} leva more!");
            }
        }
    }
}

