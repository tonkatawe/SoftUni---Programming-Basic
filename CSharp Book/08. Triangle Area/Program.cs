using System;

namespace _08._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double sidea = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (sidea * height) / 2;

            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
