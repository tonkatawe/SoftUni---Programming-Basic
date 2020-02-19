using System;

namespace _01._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            double legnht = double.Parse(Console.ReadLine());
            double wight = double.Parse(Console.ReadLine());
            double legnhtCm = legnht * 100;
            double wightCm = wight * 100;
            double rows = Math.Truncate(legnhtCm / 120);
            double desk = Math.Truncate((wightCm - 100) / 70);
            double people = (rows * desk) - 3;


            Console.WriteLine(people);
        }
    }
}
