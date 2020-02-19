using System;

namespace _08._Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double commision = -1.0;
            if (town == "Sofia" && sells > 0)
            {
                if (sells >= 0 && sells <= 500)
                {
                    commision = sells * 0.05;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commision = sells * 0.07;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commision = sells * 0.08;
                }
                else if (sells > 10000)
                {
                    commision = sells * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (town == "Varna" && sells > 0)
            {
                if (sells >= 0 && sells <= 500)
                {
                    commision = sells * 0.045;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commision = sells * 0.075;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commision = sells * 0.10;
                }
                else if (sells > 10000)
                {
                    commision = sells * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv" && sells > 0)
            {
                if (sells >= 0 && sells <= 500)
                {
                    commision = sells * 0.055;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commision = sells * 0.08;
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commision = sells * 0.12;
                }
                else if (sells > 10000)
                {
                    commision = sells * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            if ((sells >= 0) && (town == "Sofia" || town == "Plovdiv" || town == "Varna"))
            {
                Console.WriteLine($"{commision:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

