using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakes = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());
            double priceCakes = cakes * 3.2;
            double priceEggs = eggs * 4.35;
            double priceCookies = cookies * 5.4;
            double paint = eggs * 12 * 0.15;
            double total = priceCakes + priceCookies + priceEggs + paint;
            Console.WriteLine($"{total:F2}");
        }
    }
}