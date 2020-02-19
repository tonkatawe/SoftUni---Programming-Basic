using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeInSecPerM = double.Parse(Console.ReadLine());
            double distanceTime = timeInSecPerM * distanceInM;
            double dilay = Math.Floor((distanceInM / 15)) * 12.5;
            double totalivanTime = distanceTime + dilay;
            if (totalivanTime >= recordInSec)
            {
                Console.WriteLine($"No, he failed! He was {(totalivanTime - recordInSec):F2} seconds slower.");
            }
            else if (totalivanTime < recordInSec)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {(totalivanTime):F2} seconds.");
            }
        }
    }
}
