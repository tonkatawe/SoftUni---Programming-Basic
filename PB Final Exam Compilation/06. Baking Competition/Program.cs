using System;

namespace _06._Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int players = int.Parse(Console.ReadLine());
            int allBakery = 0;
            int counterCookies = 0;
            int counterCakes = 0;
            int counterWaffles = 0;
            double sum = 0;
            double endSum = 0;

            for (int i = 1; i <= players; i++)
            {
                string playerName = Console.ReadLine();
                string command = Console.ReadLine();
                counterCookies = 0;
                counterCakes = 0;
                counterWaffles = 0;
                while (command != "Stop baking!")
                {
                    string typeSweet = command;
                    int amountSweet = int.Parse(Console.ReadLine());
                    allBakery += amountSweet;
                    if (typeSweet == "cakes")
                    {
                        counterCakes += amountSweet;


                    }
                    else if (typeSweet == "waffles")
                    {
                        counterWaffles += amountSweet;

                    }
                    else if (typeSweet == "cookies")
                    {
                        counterCookies += amountSweet;

                    }
                    command = Console.ReadLine();


                }
                endSum = counterCookies * 1.5 + counterWaffles * 2.3 + counterCakes * 7.8; ;
                sum += endSum;
                endSum = 0;
                Console.WriteLine($"{playerName} baked {counterCookies} cookies, {counterCakes} cakes and {counterWaffles} waffles.");
            }

            Console.WriteLine($"All bakery sold: {allBakery}");
            Console.WriteLine($"Total sum for charity: {sum:F2} lv.");
        }
    }
}

