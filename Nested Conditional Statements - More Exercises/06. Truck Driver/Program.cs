using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double pricePerKm = 0;
            double salary = 0;
            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    pricePerKm = kmPerMonth * 4 * 0.75;
                    salary = pricePerKm - pricePerKm * 0.1;
                }
                else if (kmPerMonth <= 10000 && kmPerMonth > 5000)
                {
                    pricePerKm = kmPerMonth * 4 * 0.95;
                    salary = pricePerKm - pricePerKm * 0.1;
                }
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    pricePerKm = kmPerMonth * 4 * 0.90;
                    salary = pricePerKm - pricePerKm * 0.1;
                }
                else if (kmPerMonth <= 10000 && kmPerMonth > 5000)
                {
                    pricePerKm = kmPerMonth * 4 * 1.10;
                    salary = pricePerKm - pricePerKm * 0.1;
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    pricePerKm = kmPerMonth * 4 * 1.05;
                    salary = pricePerKm - pricePerKm * 0.1;
                }
                else if (kmPerMonth <= 10000 && kmPerMonth > 5000)
                {
                    pricePerKm = kmPerMonth * 4 * 1.25;
                    salary = pricePerKm - pricePerKm * 0.1;
                }
            }
            if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                pricePerKm = kmPerMonth * 4 * 1.45;
                salary = pricePerKm - pricePerKm * 0.1;
            }
            Console.WriteLine($"{salary:F2}");
        }
    }
}
