using System;

namespace _03._Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtSquar = int.Parse(Console.ReadLine());
            double widhtTIle = double.Parse(Console.ReadLine());
            double lenghtTile = double.Parse(Console.ReadLine());
            int wightBench = int.Parse(Console.ReadLine());
            int lenghtBench = int.Parse(Console.ReadLine());
            double squarArea = lenghtSquar * lenghtSquar;
            double benchArea = lenghtBench * wightBench;
            double areaTile = widhtTIle * lenghtTile;
            double areaWithTile = squarArea - benchArea;
            double amountTile = areaWithTile / areaTile;
            double nesecceryTIme = amountTile * 0.2;
            Console.WriteLine($"{amountTile}");
            Console.WriteLine($"{nesecceryTIme}");
        }
    }
}

