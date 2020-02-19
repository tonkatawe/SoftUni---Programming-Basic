using System;

namespace _02._Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookDay = int.Parse(Console.ReadLine());
            int bookMonth = int.Parse(Console.ReadLine());
            int accomodationDay = int.Parse(Console.ReadLine());
            int accomadationMonth = int.Parse(Console.ReadLine());
            int leavingDay = int.Parse(Console.ReadLine());
            int leavingMonth = int.Parse(Console.ReadLine());
            int stayDays = leavingDay - accomodationDay;
            double price = 0;
            if (accomodationDay - bookDay >= 10)
            {
                price = stayDays * 25;
            }
            if (bookMonth < accomadationMonth)
            {
                price = 25 * stayDays - 25 * stayDays * 0.2;
            }
            else
            {
                price = 30 * stayDays;
            }
            Console.WriteLine($"Your stay from {accomodationDay}/{accomadationMonth} to {leavingDay}/{leavingMonth} will cost {price:F2}");

        }
    }
}

