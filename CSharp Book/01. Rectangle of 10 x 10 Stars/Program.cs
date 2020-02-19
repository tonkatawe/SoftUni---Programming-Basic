using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}

