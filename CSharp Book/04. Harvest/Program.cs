using System;

namespace _04._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaGrapes = int.Parse(Console.ReadLine());
            double grapesPerM = double.Parse(Console.ReadLine());
            int needLitters = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            double amountGrades = areaGrapes * grapesPerM;
            double wine = (amountGrades * 0.4) / 2.5;
            if (wine >= needLitters)
            {
                double restLiters = wine - needLitters;
                double litersPerWorkers = restLiters / countWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(restLiters)} liters left -> {Math.Ceiling(litersPerWorkers)} liters per person.");
            }
            if (wine < needLitters)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needLitters - wine)} liters wine needed.");
            }
        }
    }
}
