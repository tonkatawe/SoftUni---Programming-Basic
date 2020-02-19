using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 2; j <= num2; j++)
                {
                    for (int k = 1; k <= num3; k++)
                    {

                        if ((i % 2 == 0 && k % 2 == 0) && (j == 3 || j == 2 || j == 5 || j == 7))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
