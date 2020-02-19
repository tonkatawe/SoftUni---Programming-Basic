using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            for (int rows = 1; rows <= num; rows++)
            {
                for (int figures = 1; figures <= rows; figures++)
                {
                    if (current > num)
                    {

                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (current > num)
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}
