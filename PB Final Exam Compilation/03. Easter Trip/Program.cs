using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double cost = 0;
            if (destination == "France")
            {
                if (date == "21-23")
                {
                    cost = 30;
                }
                if (date == "24-27")
                {
                    cost = 35;
                }
                if (date == "28-31")
                {
                    cost = 40;
                }
            }
            if (destination == "Italy")
            {
                if (date == "21-23")
                {
                    cost = 28;
                }
                if (date == "24-27")
                {
                    cost = 32;
                }
                if (date == "28-31")
                {
                    cost = 39;
                }
            }
            if (destination == "Germany")
            {
                if (date == "21-23")
                {
                    cost = 32;
                }
                if (date == "24-27")
                {
                    cost = 37;
                }
                if (date == "28-31")
                {
                    cost = 43;
                }
            }
            double total = cost * nights;
            Console.WriteLine($"Easter trip to {destination} : {total:F2} leva.");
        }
    }
}

