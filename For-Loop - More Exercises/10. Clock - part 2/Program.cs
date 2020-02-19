using System;

namespace _10._Clock___part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    for (int n = 0; n <= +59; n++)
                    {
                        Console.WriteLine($"{i} : {j} : {n}");
                    }
                }
            }
        }
    }
}
