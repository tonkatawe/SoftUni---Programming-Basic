﻿using System;

namespace _07._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y1 - y2);
            Console.WriteLine(width * height);
            Console.WriteLine(2 * (width + height));
        }
    }
}

