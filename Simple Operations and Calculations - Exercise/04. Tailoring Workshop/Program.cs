using System;

namespace _04._Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTable = int.Parse(Console.ReadLine());
            double lightTable = double.Parse(Console.ReadLine());
            double wightTable = double.Parse(Console.ReadLine());
            double areaCover = countTable * ((lightTable + 2 * 0.30) * (wightTable + 2 * 0.30));
            double square = countTable * ((lightTable / 2)) * ((lightTable / 2));
            double USprice = areaCover * 7 + square * 9;
            double BGNprice = USprice * 1.85;
            Console.WriteLine($"{USprice:F2} USD");
            Console.WriteLine($"{BGNprice:F2} BGN");

        }
    }
}