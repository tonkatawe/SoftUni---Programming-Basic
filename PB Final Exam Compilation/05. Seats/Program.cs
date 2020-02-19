using System;

namespace _05._Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTicket = int.Parse(Console.ReadLine());
            char a = '0';
            for (int i = 0; i < numTicket; i++)
            {
                string ticket = Console.ReadLine();
                a = (char)ticket[0];
                if (ticket.Length > 4)
                {
                    Console.WriteLine($"Seat decoded: {ticket[0]}{(int)ticket[1]}");
                    continue;
                }
                if ((char)ticket[0] >= (char)65 && (char)ticket[0] <= (char)90)
                {
                    Console.WriteLine($"Seat decoded: {ticket[0]}{ticket[1]}{ticket[2]}");

                }
                else
                {
                    Console.WriteLine($"Seat decoded: {ticket[3]}{ticket[1]}{ticket[2]}");
                }

            }
        }
    }
}
