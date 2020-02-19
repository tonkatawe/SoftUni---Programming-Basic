using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            double maxNumber = double.MinValue;
            while (counter <= num)
            {
                int cnum = int.Parse(Console.ReadLine());
                if (cnum >= maxNumber)
                {
                    maxNumber = cnum;
                }
                counter++;
            }
            Console.WriteLine(maxNumber);
        }
    }
}