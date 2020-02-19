using System;

namespace _04._Best_Plane_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberTickets = Console.ReadLine();
            double ticketPrice = 0;
            int minutesStay = 0;
            int minimumStay = int.MaxValue;
            double priceInLev = 0;
            int stayHours = 0;
            int stayMinutes = 0;
            double minPrice = 0;
            string bestFligths = string.Empty;

            while (numberTickets != "End")
            {
                ticketPrice = double.Parse(Console.ReadLine());
                minutesStay = int.Parse(Console.ReadLine());
                priceInLev = ticketPrice * 1.96;
                if (minutesStay < minimumStay)
                {
                    minimumStay = minutesStay;
                    minPrice = priceInLev;
                    bestFligths = numberTickets;
                }
                numberTickets = Console.ReadLine();
            }
            stayHours = minimumStay / 60;
            stayMinutes = minimumStay % 60;
            Console.WriteLine($"Ticket found for flight {bestFligths} costs {minPrice:F2} leva with {stayHours}h {stayMinutes}m stay");

        }
    }
}
