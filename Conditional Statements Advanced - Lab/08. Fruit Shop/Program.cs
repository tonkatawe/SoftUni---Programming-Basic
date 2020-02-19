using System;

namespace _08._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursdau" || dayOfWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                }


            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                }

            }
            if (price > 0)
            {

                double totalsum = quantity * price;
                Console.WriteLine($"{totalsum:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

    }
}






