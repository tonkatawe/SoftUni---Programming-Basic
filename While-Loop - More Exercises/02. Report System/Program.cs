using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {

            double expectSum = double.Parse(Console.ReadLine());
            double countCash = 0;
            double countCard = 0;
            double sumCash = 0;
            double sumCard = 0;
            double totalSum = sumCash + sumCard;
            string input = string.Empty;
            while (expectSum <= 10000 && expectSum >= 1 && totalSum < expectSum)
            {
                double cash = 0;
                double card = 0;
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                cash += double.Parse(input);
                if (cash > 100 && cash != 0)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    Console.WriteLine("Product sold!");
                    sumCash += cash;
                    countCash++;
                }
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                card += double.Parse(input);
                if (card < 10 && card != 0)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    Console.WriteLine("Product sold!");
                    sumCard += card;
                    countCard++;
                }
                totalSum = sumCard + sumCash;
                if (totalSum >= expectSum)
                {

                }
            }
            double averageCard = sumCard / countCard;
            double averageCash = sumCash / countCash;
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {averageCash:F2}");
                Console.WriteLine($"Average CC: {averageCard:F2}");
            }
        }
    }
}
