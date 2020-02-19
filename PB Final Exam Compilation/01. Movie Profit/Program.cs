using System;

namespace _01._Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double procentCasino = double.Parse(Console.ReadLine());
            double priceDays = price * tickets;
            double allDays = days * priceDays;
            double forCasino = allDays * procentCasino / 100;
            double total = allDays - forCasino;
            Console.WriteLine($"The profit from the movie {movieName} is {total:F2} lv.");
        }
    }
}
