using System;

namespace _09._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string wetherhot = "sunny";
            wetherhot = Console.ReadLine();
            string cloud = "cloudy";
            cloud = Console.ReadLine();
            string snow = "snowy";
            snow = Console.ReadLine();

            if (wetherhot == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
