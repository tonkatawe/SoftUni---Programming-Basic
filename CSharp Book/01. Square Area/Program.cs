using System;

namespace _01._Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Square area = ");
            int area = a * a;
            Console.WriteLine(area);
        }
    }
}