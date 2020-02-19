using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double minNumber = double.MaxValue;
            int counter = 1;
            while (n >= counter)
            {
                int curNUm = int.Parse(Console.ReadLine());
                if (curNUm <= minNumber)
                {
                    minNumber = curNUm;
                }
                counter++;
            }
            Console.WriteLine(minNumber);
        }
    }
}

