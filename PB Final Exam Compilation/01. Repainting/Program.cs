using System;

namespace _01._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountNylon = int.Parse(Console.ReadLine());
            int amountPaint = int.Parse(Console.ReadLine());
            int amountDiliuent = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());
            double nylonPrice = (amountNylon + 2) * 1.50;
            double paintPrice = (amountPaint + amountPaint * 0.1) * 14.5;
            double diliuentPrice = amountDiliuent * 5;
            double sum = nylonPrice + paintPrice + diliuentPrice + 0.4;
            double salary = (sum * 0.3) * workHours;
            double total = sum + salary;
            Console.WriteLine($"Total expenses: {total:F2} lv.");
        }
    }
}
