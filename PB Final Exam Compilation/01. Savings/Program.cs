using System;

namespace _01._Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double earns = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double neededSum = double.Parse(Console.ReadLine());
            double badSituation = 0.3 * earns;
            double saveMoney = earns - (neededSum + badSituation);
            double savePercent = saveMoney / earns * 100;
            Console.WriteLine($"She can save {savePercent:F2}%");
            Console.WriteLine($"{months * saveMoney:F2}");



        }
    }
}
