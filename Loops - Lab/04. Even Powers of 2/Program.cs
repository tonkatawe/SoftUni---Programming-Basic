﻿using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pow = 1;
            for (int i = 0; i <= n; i += 2)
            {


                Console.WriteLine(pow);
                pow = pow * 2 * 2;
            }
        }
    }
}