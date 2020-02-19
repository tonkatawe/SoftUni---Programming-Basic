using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double wantProfit = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int amountCoctails = 0;
            double price = 0;
            double sum = 0;
            double totalSum = 0;
            while (command != "Party!")
            {
                amountCoctails = int.Parse(Console.ReadLine());
                price = command.Length;
                sum = price * amountCoctails;
                if (sum % 2 == 1)
                {
                    sum = sum - sum * 0.25;
                }
                totalSum += sum;
                if (totalSum >= wantProfit)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Party!")
            {
                double needSum = wantProfit - totalSum;
                Console.WriteLine($"We need {needSum:F2} leva more.");
                Console.WriteLine($"Club income - {totalSum:F2} leva.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
                Console.WriteLine($"Club income - {totalSum:F2} leva.");
            }
        }
    }
}

