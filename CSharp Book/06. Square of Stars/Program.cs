using System;

namespace _06._Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string squarstars = new string('*', n);

            Console.WriteLine(squarstars);
            for (int i = 1; i < n - 1; i++)
            {
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }
            Console.WriteLine(squarstars);
        }
    }
}