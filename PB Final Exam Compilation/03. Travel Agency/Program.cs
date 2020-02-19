using System;

namespace _03._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string resortName = Console.ReadLine();
            string type = Console.ReadLine();
            string VIP = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double pricePerDay = 0;
            double price = 0;
            if (days > 7)
            {
                days = days - 1;
            }
            if (resortName == "Bansko" || resortName == "Borovets")
            {
                if (type == "noEquipment")
                {
                    if (VIP == "yes")
                    {
                        pricePerDay = 80 - 80 * 0.05;
                    }
                    if (VIP == "no")
                    {
                        pricePerDay = 80;

                    }
                }
                if (type == "withEquipment")
                {

                    if (VIP == "yes")
                    {
                        pricePerDay = 100 - 100 * 0.10;
                    }
                    if (VIP == "no")
                    {
                        pricePerDay = 100;

                    }
                }
            }
            else if (resortName == "Varna" || resortName == "Burgas")
            {
                if (type == "noBreakfast")
                {

                    if (VIP == "yes")
                    {
                        pricePerDay = 100 - 100 * 0.07;
                    }
                    if (VIP == "no")
                    {
                        pricePerDay = 100;

                    }
                }
                if (type == "withBreakfast")
                {

                    if (VIP == "yes")
                    {
                        pricePerDay = 130 - 130 * 0.12;
                    }
                    if (VIP == "no")
                    {
                        pricePerDay = 130;

                    }
                }
            }
            price = pricePerDay * days;
            if (days > 1)
            {

                Console.WriteLine($"The price is {price:F2}lv! Have a nice time!");
            }
            else
            {
                Console.WriteLine("Days must be positive number!");
            }
            if (resortName != "Bansko" && resortName != "Borovets" && resortName != "Varna" && resortName != "Burgas")
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}

