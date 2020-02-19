using System;

namespace _01._Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double sidaA = double.Parse(Console.ReadLine());
            double sidaB = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double area = (sidaA + sidaB) * hight / 2;
            Console.WriteLine($"{area:F2}");
        }
    }
}