﻿using System;

namespace _07._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3;
            int minutes = sum / 60;
            int secondes = sum % 60;
            if (secondes < 10)
            {
                Console.WriteLine($"{minutes}:0{secondes}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{secondes}");
            }
        }
    }
}

