using System;

namespace _05._Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lightHallM = double.Parse(Console.ReadLine());
            double wightHallM = double.Parse(Console.ReadLine());
            double sideWordrobeM = double.Parse(Console.ReadLine());
            double areaHallCm = (lightHallM * 100) * (wightHallM * 100);
            double sizewordrobesidecm = sideWordrobeM * 100;
            double sizewordrobe = sizewordrobesidecm * sizewordrobesidecm;
            double sizebench = areaHallCm / 10;
            double freeArea = areaHallCm - sizewordrobe - sizebench;
            double countdancer = Math.Floor(freeArea / (40 + 7000));
            Console.WriteLine(countdancer);
        }
    }
}