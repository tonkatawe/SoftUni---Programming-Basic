using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtM = double.Parse(Console.ReadLine());
            double wight = double.Parse(Console.ReadLine());
            double lenghtCM = lenghtM * 100;
            double wightCM = wight * 100;
            double rows = Math.Truncate(lenghtCM / 120);
            double desk = Math.Truncate((wightCM - 100) / 70);
            double people = rows * desk - 3;
            Console.WriteLine(people);
        }
    }
}
