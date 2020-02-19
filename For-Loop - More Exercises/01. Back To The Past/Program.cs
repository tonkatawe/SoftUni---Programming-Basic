using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int deadYear = int.Parse(Console.ReadLine());
            double waste = 0;
            double rest = 0;
            int age = 18;

            for (int i = 1800; i <= deadYear; i++)
            {

                if (i % 2 == 0)
                {
                    waste += 12000;
                }
                if (i % 2 != 0)
                {
                    waste += (12000 + age * 50);
                }
                age++;
            }
            rest = inheritance - waste;
            if (rest >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {rest:F2} dollars left.");
            }
            else
            {
                double need = waste - inheritance;
                Console.WriteLine($"He will need {need:F2} dollars to survive.");
            }
        }
    }
}
