using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volumeCM = lenght * width * hight;
            double volumeL = volumeCM * 0.001;
            double percent2 = percent * 0.01;
            double litre = volumeL * (1 - percent2);
            Console.WriteLine("{0:F3}", litre);
        }
    }
}
