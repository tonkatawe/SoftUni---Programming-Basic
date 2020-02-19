using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double results = 0;
            double rowOne = 0;
            double rowTwo = 0;
            double rowThree = 0;
            double rowfour = 0;
            double rowfive = 0;
            double invalidNum = 0;
            for (int i = 0; i < n; i++)
            {
                double score = double.Parse(Console.ReadLine());
                if (score < 0 || score > 50)
                {
                    invalidNum++;
                    results = results / 2;
                }
                if (score >= 0 && score <= 9)
                {
                    rowOne++;
                    results += score * 0.2;
                }
                if (score >= 10 && score <= 19)
                {
                    rowTwo++;
                    results += score * 0.3;
                }
                if (score >= 20 && score <= 29)
                {
                    rowThree++;
                    results += score * 0.4;
                }
                if (score >= 30 && score <= 39)
                {
                    rowfour++;
                    results += 50;
                }
                if (score >= 40 && score <= 50)
                {
                    rowfive++;
                    results += 100;
                }
            }
            double one = rowOne / n * 100;
            double two = rowTwo / n * 100;
            double three = rowThree / n * 100;
            double four = rowfour / n * 100;
            double five = rowfive / n * 100;
            double seven = invalidNum / n * 100;
            Console.WriteLine($"{results:F2}");
            Console.WriteLine($"From 0 to 9: {one:F2}%");
            Console.WriteLine($"From 10 to 19: {two:F2}%");
            Console.WriteLine($"From 20 to 29: {three:F2}%");
            Console.WriteLine($"From 30 to 39: {four:F2}%");
            Console.WriteLine($"From 40 to 50: {five:F2}%");
            Console.WriteLine($"Invalid numbers: {seven:F2}%");


        }
    }
}
