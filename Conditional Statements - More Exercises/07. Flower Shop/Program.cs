using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMagnolies = int.Parse(Console.ReadLine());
            int countZiombilis = int.Parse(Console.ReadLine());
            int countRosses = int.Parse(Console.ReadLine());
            int countCactusses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double totalSum = countCactusses * 8 + countMagnolies * 3.25 + countRosses * 3.5 + countZiombilis * 4;
            double tax = totalSum * 0.05;
            double total = totalSum - tax;
            if (total < giftPrice)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - total)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(total - giftPrice)} leva.");
            }


        }
    }
}
