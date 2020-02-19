using System;

namespace _03._Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCruise = Console.ReadLine();
            string typeCabin = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
            double price = 0;
            if (typeCruise == "Mediterranean")
            {
                if (typeCabin == "standard cabin")
                {
                    price = night * 27.50;
                }
                if (typeCabin == "cabin with balcony")
                {
                    price = night * 30.20;
                }
                if (typeCabin == "apartment")
                {
                    price = night * 40.50;
                }
            }
            if (typeCruise == "Adriatic")
            {
                if (typeCabin == "standard cabin")
                {
                    price = night * 22.99;
                }
                if (typeCabin == "cabin with balcony")
                {
                    price = night * 25.00;
                }
                if (typeCabin == "apartment")
                {
                    price = night * 34.99;
                }
            }
            if (typeCruise == "Aegean")
            {
                if (typeCabin == "standard cabin")
                {
                    price = night * 23.00;
                }
                if (typeCabin == "cabin with balcony")
                {
                    price = night * 26.60;
                }
                if (typeCabin == "apartment")
                {
                    price = night * 39.80;
                }
            }
            price *= 4;
            if (night > 7)
            {
                price = price - price * 0.25;
                Console.WriteLine($"Annie's holiday in the {typeCruise} sea costs {price:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Annie's holiday in the {typeCruise} sea costs {price:F2} lv.");
            }

        }
    }
}

