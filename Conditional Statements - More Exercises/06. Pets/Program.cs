using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            int allFoodPerPetsKg = int.Parse(Console.ReadLine());
            double foodPerDogKg = double.Parse(Console.ReadLine());
            double foodPerCatKg = double.Parse(Console.ReadLine());
            double foodPerTurtleGrames = double.Parse(Console.ReadLine());
            double neededFoodDog = countDays * foodPerDogKg;
            double neededFoodCat = countDays * foodPerCatKg;
            double neededFoodTurtle = (countDays * foodPerTurtleGrames) / 1000;
            double allFood = neededFoodCat + neededFoodDog + neededFoodTurtle;
            if (allFood <= allFoodPerPetsKg)
            {
                Console.WriteLine($"{Math.Floor(allFoodPerPetsKg - allFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allFood - allFoodPerPetsKg)} more kilos of food are needed.");
            }

        }
    }
}
