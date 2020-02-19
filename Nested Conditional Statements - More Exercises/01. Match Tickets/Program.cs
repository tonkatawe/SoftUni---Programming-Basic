using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            double fens = double.Parse(Console.ReadLine());
            double cash = 0;
            double price = 0;
            if (category == "Normal")
            {
                price = fens * 249.99;
                if (fens >= 1 && fens <= 4)
                {
                    cash = buget - buget * .75;
                }
                else if (fens >= 5 && fens <= 9)
                {
                    cash = buget - buget * 0.60;
                }
                else if (fens >= 10 && fens <= 24)
                {
                    cash = buget - buget * 0.50;
                }
                else if (fens >= 25 && fens <= 49)
                {
                    cash = buget - buget * 0.40;
                }
                else if (fens >= 50)
                {
                    cash = buget - buget * 0.25;
                }
            }
            if (category == "VIP")
            {
                price = fens * 499.99;
                if (fens >= 1 && fens <= 4)
                {
                    cash = buget - buget * .75;
                }
                else if (fens >= 5 && fens <= 9)
                {
                    cash = buget - buget * 0.60;
                }
                else if (fens >= 10 && fens <= 24)
                {
                    cash = buget - buget * 0.50;
                }
                else if (fens >= 25 && fens <= 49)
                {
                    cash = buget - buget * 0.40;
                }
                else if (fens >= 50)
                {
                    cash = buget - buget * 0.25;
                }
            }
            if (cash >= price)
            {
                Console.WriteLine($"Yes! You have {(cash - price):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - cash):F2} leva.");
            }
        }
    }
}
