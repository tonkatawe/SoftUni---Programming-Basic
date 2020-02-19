using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottle = int.Parse(Console.ReadLine());
            int detragent = bottle * 750;
            string amountDish = string.Empty;
            int rest = detragent;
            int spent = 0;
            int notEnd = 0;
            int needed = 0;
            int countDish = 0;
            int countPot = 0;
            int counter = 0;
            while (rest >= 0 && bottle != 0)
            {
                counter++;
                amountDish = (Console.ReadLine());
                if (amountDish == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{countDish} dishes and {countPot} pots were washed.");
                    Console.WriteLine($"Leftover detergent {Math.Abs(rest)} ml.");
                    break;
                }
                notEnd = int.Parse(amountDish);
                needed = notEnd * 5;
                spent = detragent - needed;
                if (spent < 0)
                {
                    rest = notEnd * 5 - rest;
                    Console.WriteLine($"Not enough detergent, {Math.Abs(rest)} ml. more necesary!");
                    break;
                }

                if (counter == 3)
                {
                    needed = notEnd * 15;
                    spent = rest - needed;
                    if (spent < 0)
                    {
                        rest = notEnd * 15 - rest;
                        Console.WriteLine($"Not enough detergent, {Math.Abs(rest)} ml. more necessary!");
                        break;
                    }
                    counter = 0;
                    countPot += notEnd;
                }
                else
                {
                    countDish += notEnd;
                }
                rest = detragent - countPot * 15 - countDish * 5;
                spent = detragent - rest;

            }


        }
    }
}