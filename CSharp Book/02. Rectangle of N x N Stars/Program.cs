﻿using System;

namespace _02._Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}