using System;

namespace _10._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int wideFreeSpace = int.Parse(Console.ReadLine());
            int lenghtFreeSpace = int.Parse(Console.ReadLine());
            int hinghtFreeSpace = int.Parse(Console.ReadLine());
            string countOfBox = Console.ReadLine();
            int boxes = 0;
            double volume = wideFreeSpace * lenghtFreeSpace * hinghtFreeSpace;
            while (countOfBox != "Done")
            {
                boxes += int.Parse(countOfBox);
                if (volume < boxes)
                {
                    break;
                }
                countOfBox = Console.ReadLine();
            }
            if (countOfBox == "Done")
            {
                Console.WriteLine($"{volume - boxes} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {boxes - volume} Cubic meters more.");
            }
        }
    }
}
