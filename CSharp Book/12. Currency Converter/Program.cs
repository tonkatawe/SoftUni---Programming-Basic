using System;

namespace _12._Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Currency = double.Parse(Console.ReadLine());
            double bgn = 1.00;
            double eur = bgn * 1.95583;
            double gbr = bgn * 2.53405;
            double usd = bgn * 1.79549;

            string firstCurrency = Console.ReadLine();

            string secondCurrency = Console.ReadLine();

            if (firstCurrency == "USD")
            {
                if (secondCurrency == "BGN")
                    Console.WriteLine($"{Currency * usd:F2}");
            }
            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "EUR")
                    Console.WriteLine($"{Currency * bgn / eur:F2}");
            }
            if (firstCurrency == "EUR")
            {
                if (secondCurrency == "GBP")
                    Console.WriteLine($"{Currency * eur / gbr:F2}");
            }
            if (firstCurrency == "USD")
            {
                if (secondCurrency == "EUR")
                    Console.WriteLine($"{Currency * usd / eur:F2}");
            }
            if (firstCurrency == "EUR")
            {
                if (secondCurrency == "USD")
                    Console.WriteLine($"{Currency * eur / usd:F2}");
            }
            if (firstCurrency == "GBP")
            {
                if (secondCurrency == "BGN")
                    Console.WriteLine($"{Currency * gbr / bgn:F2}");
            }
            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "GBP")
                    Console.WriteLine($"{Currency * bgn / gbr:F2}");
            }
            if (firstCurrency == "EUR")
            {
                if (secondCurrency == "BGN")
                    Console.WriteLine($"{Currency * eur / bgn:F2}");

            }
            if (firstCurrency == "GBP")
            {
                if (secondCurrency == "USD")
                    Console.WriteLine($"{Currency * gbr / usd:F2}");
            }
            if (firstCurrency == "GBP")
            {
                if (secondCurrency == "EUR")
                    Console.WriteLine($"{Currency * gbr / eur:F2}");
            }
            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "USD")
                    Console.WriteLine($"{Currency * bgn / usd:F2}");
            }
            if (firstCurrency == "USD")
            {
                if (secondCurrency == "GBP")
                    Console.WriteLine($"{Currency * usd / gbr:F2}");
            }
            if (firstCurrency == "USD")
            {
                if (secondCurrency == "USD")
                    Console.WriteLine($"{Currency * usd / usd:F2}");

            }
            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "BGN")
                    Console.WriteLine($"{Currency * bgn / bgn:F2}");

            }
            if (firstCurrency == "EUR")
            {
                if (secondCurrency == "EUR")
                    Console.WriteLine($"{Currency * eur / eur:F2}");

            }
            if (firstCurrency == "GBP")
            {
                if (secondCurrency == "GBP")
                    Console.WriteLine($"{Currency * gbr / gbr:F2}");

            }
        }
    }
}
