using System;

namespace _01._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometres = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double priceKM = 0.0;
            double taxiRate = 0.0;
            if (dayOrNight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }
            if (kilometres < 20)
            {
                priceKM = 0.70 + kilometres * taxiRate;
            }
            else if (kilometres < 100)
            {
                priceKM = kilometres * 0.09;
            }
            else
            {
                priceKM = kilometres * 0.06;
            }
            Console.WriteLine(priceKM);


        }
    }
}
