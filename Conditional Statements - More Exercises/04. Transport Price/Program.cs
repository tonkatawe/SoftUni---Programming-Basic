using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfKm = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0.0;
            if (dayOrNight == "day")
            {
                price = 0.79;
            }
            if (dayOrNight == "night")
            {
                price = 0.90;
            }
            if (countOfKm < 20)
            {
                double costOne = price * countOfKm + 0.70;
                Console.WriteLine($"{costOne:F2}");
            }
            else if (countOfKm >= 20 && countOfKm < 100)
            {
                price = countOfKm * 0.09;
                Console.WriteLine($"{price:F2}");
            }
            else if (countOfKm >= 100)
            {
                price = countOfKm * 0.06;
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
