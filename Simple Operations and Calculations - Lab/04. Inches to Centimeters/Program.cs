using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cantimeters = inches * 2.54;
            Console.WriteLine("{0:F2}", cantimeters);
        }
    }
}