using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double nextMonths = 0;
            double eletricity = 0;
            double other = 0;
            double average = 0;
            for (int i = 0; i < months; i++)
            {
                nextMonths = double.Parse(Console.ReadLine());
                eletricity += nextMonths;
                other += (nextMonths + 15 + 20) + (nextMonths + 15 + 20) * 0.2;



            }
            double water = 20 * months;
            double internet = 15 * months;
            average = (water + internet + other + eletricity) / months;
            Console.WriteLine($"Electricity: {eletricity:F2} lv");
            Console.WriteLine($"Water: {water:F2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {other:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
