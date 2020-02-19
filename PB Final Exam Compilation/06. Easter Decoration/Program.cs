using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double avarrage = 0;
            for (int i = 1; i <= clients; i++)
            {
                int counter = 0;
                double price = 0;
                string command = Console.ReadLine();
                while (command != "Finish")
                {
                    counter++;
                    if (command == "basket")
                    {
                        price += 1.5;
                    }
                    if (command == "wreath")
                    {
                        price += 3.8;
                    }
                    if (command == "chocolate bunny")
                    {
                        price += 7;
                    }
                    command = Console.ReadLine();
                }
                if (counter % 2 == 0)
                {
                    price = price * .8;
                }
                avarrage += price;
                Console.WriteLine($"You purchased {counter} items for {price:F2} leva.");
            }
            Console.WriteLine($"Average bill per client is: {(avarrage / clients):F2} leva.");
        }
    }
}

