using System;

namespace _02._Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string session = Console.ReadLine();
            string typeOfHoliday = "";
            string distination = "";
            double costs = 0;
            if ((buget <= 100) && (session == "summer" || session == "winter"))
            {
                distination = "Bulgaria";
                if (session == "summer")
                {
                    typeOfHoliday = "Camp";
                    costs = buget * 0.3;
                }
                else if (session == "winter")
                {
                    typeOfHoliday = "Hotel";
                    costs = buget * 0.7;
                }
            }
            else if ((buget <= 1000 && buget > 100) && (session == "summer" || session == "winter"))
            {
                distination = "Balkans";
                if (session == "summer")
                {
                    typeOfHoliday = "Camp";
                    costs = buget * 0.4;
                }
                else if (session == "winter")
                {
                    typeOfHoliday = "Hotel";
                    costs = buget * 0.8;
                }
            }
            else if ((buget > 1000) && (session == "summer" || session == "winter"))
            {
                distination = "Europe";

                typeOfHoliday = "Hotel";
                costs = buget * 0.9;

            }
            Console.WriteLine($"Somewhere in {distination}");
            Console.WriteLine($"{typeOfHoliday} - {costs:F2}");
        }
    }
}

