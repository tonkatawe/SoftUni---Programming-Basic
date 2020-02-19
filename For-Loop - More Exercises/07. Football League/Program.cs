using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());
            double fansA = 0;
            double fansB = 0;
            double fansV = 0;
            double fansG = 0;
            for (int i = 0; i < fans; i++)
            {
                char ultras = char.Parse(Console.ReadLine());
                if (ultras == 'A')
                {
                    fansA++;
                }
                if (ultras == 'B')
                {
                    fansB++;
                }
                if (ultras == 'V')
                {
                    fansV++;
                }
                if (ultras == 'G')
                {
                    fansG++;
                }
            }
            double rowOne = fansA / fans * 100;
            double rowTwo = fansB / fans * 100;
            double rowThree = fansV / fans * 100;
            double rowFour = fansG / fans * 100;
            double sum = fansA + fansB + fansV + fansG;
            double average = sum / capacity * 100;
            Console.WriteLine($"{rowOne:F2}%");
            Console.WriteLine($"{rowTwo:F2}%");
            Console.WriteLine($"{rowThree:F2}%");
            Console.WriteLine($"{rowFour:F2}%");
            Console.WriteLine($"{average:F2}%");
        }
    }
}

