using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {

            double houseHeight = double.Parse(Console.ReadLine());
            double houseLenght = double.Parse(Console.ReadLine());
            double roofHeight = double.Parse(Console.ReadLine());
            double wallsWithWindow = 2 * (houseHeight * houseLenght) - 2 * 1.5 * 1.5;
            double FrontAndBackWalls = 2 * (houseHeight * houseHeight) - 1.2 * 2;
            double greenpaint = (wallsWithWindow + FrontAndBackWalls) / 3.4;
            double roof = 2 * (houseHeight * houseLenght) + 2 * (houseHeight * roofHeight / 2);
            double redpaint = roof / 4.3;

            Console.WriteLine($"{greenpaint:F2}");
            Console.WriteLine($"{redpaint:F2}");
        }
    }
}