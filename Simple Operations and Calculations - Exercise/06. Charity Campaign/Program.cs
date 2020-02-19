using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daycount = int.Parse(Console.ReadLine());
            int cookcount = int.Parse(Console.ReadLine());
            int cakecount = int.Parse(Console.ReadLine());
            int gofretacount = int.Parse(Console.ReadLine());
            int pancakecount = int.Parse(Console.ReadLine());
            double moneybycake = cakecount * 45;
            double moneybygofreta = gofretacount * 5.80;
            double moneybypancake = pancakecount * 3.20;
            double totalperday = (moneybycake + moneybygofreta + moneybypancake) * cookcount;
            double totalcampany = totalperday * daycount;
            double totalaftercost = totalcampany - totalcampany / 8;

            Console.WriteLine($"{totalaftercost:F2}");
        }
    }
}
