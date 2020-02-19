using System;

namespace _06._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());
            double totalsum = dogCount * 2.5 + otherAnimals * 4;
            Console.WriteLine("{0:F2} lv.", totalsum);
        }
    }
}