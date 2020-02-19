using System;

namespace _08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            int fuelCount = int.Parse(Console.ReadLine());
            if (fuelType != "Diesel" && fuelType != "Gas" && fuelType != "Gasoline")
            {
                Console.WriteLine("Invalid fuel!");
            }
            if (fuelCount >= 25 && (fuelType == "Diesel" || fuelType == "Gas" || fuelType == "Gasoline"))
            {

                Console.WriteLine($"You have enough {fuelType.ToLower()}.");
            }
            else if (fuelCount < 25 && (fuelType == "Diesel" || fuelType == "Gas" || fuelType == "Gasoline"))
            {

                Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
            }

        }
    }
}
