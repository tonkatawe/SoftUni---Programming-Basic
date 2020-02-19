using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid Number");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}