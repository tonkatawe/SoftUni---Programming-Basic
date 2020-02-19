using System;

namespace _03._Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string typePacket = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            if (filmName == "John Wick")
            {
                if (typePacket == "Drink")
                {
                    ticketPrice = 12;
                }
                if (typePacket == "Popcorn")
                {
                    ticketPrice = 15;
                }
                if (typePacket == "Menu")
                {
                    ticketPrice = 19;
                }

            }
            if (filmName == "Star Wars")
            {
                if (typePacket == "Drink")
                {
                    ticketPrice = 18;
                }
                if (typePacket == "Popcorn")
                {
                    ticketPrice = 25;
                }
                if (typePacket == "Menu")
                {
                    ticketPrice = 30;
                }
                if (tickets >= 4)
                {
                    ticketPrice = ticketPrice - ticketPrice * 0.3;
                }

            }
            if (filmName == "Jumanji")
            {
                if (typePacket == "Drink")
                {
                    ticketPrice = 9;
                }
                if (typePacket == "Popcorn")
                {
                    ticketPrice = 11;
                }
                if (typePacket == "Menu")
                {
                    ticketPrice = 14;
                }
                if (tickets == 2)
                {
                    ticketPrice = ticketPrice - ticketPrice * 0.15;
                }

            }
            double total = ticketPrice * tickets;
            Console.WriteLine($"Your bill is {total:F2} leva.");
        }
    }
}
