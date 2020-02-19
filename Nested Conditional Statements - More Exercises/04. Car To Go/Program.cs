using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carClass = "";
            string carType = "";
            double carPrice = 0;
            if (season == "Summer")
            {
                carType = "Cabrio";
                if (buget <= 100)
                {
                    carClass = "Economy class";
                    carPrice = buget * 0.35;
                }
                else if (buget > 100 && buget <= 500)
                {
                    carClass = "Compact class";
                    carPrice = buget * 0.45;
                }

            }
            if (season == "Winter")
            {
                carType = "Jeep";
                if (buget <= 100)
                {
                    carClass = "Economy class";
                    carPrice = buget * 0.65;
                }
                else if (buget > 100 && buget <= 500)
                {
                    carClass = "Compact class";
                    carPrice = buget * 0.80;
                }
                if (buget > 500)
                {
                    carType = "Jeep";
                    carClass = "Luxury class";
                    carPrice = buget * 0.9;
                }
            }
            if (buget > 500)
            {
                carType = "Jeep";
                carClass = "Luxury class";
                carPrice = buget * 0.9;
            }
            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {carPrice:F2}");
        }
    }
}

