using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSectorOfSectors = char.Parse(Console.ReadLine());
            int rowsInFirstSector = int.Parse(Console.ReadLine());
            int seatsInOddRow = int.Parse(Console.ReadLine());
            int nextSecotrsRows = rowsInFirstSector + 1;
            int counter = 0;

            for (char sectors = 'A'; sectors <= lastSectorOfSectors; sectors++)
            {
                for (int rows = 1; rows <= rowsInFirstSector; rows++)
                {
                    int seatsInEvenRow = 0;
                    if (rows % 2 == 0)
                    {
                        seatsInEvenRow = 97 + seatsInOddRow + 2;
                    }
                    else
                    {
                        seatsInEvenRow = 97 + seatsInOddRow;
                    }
                    for (int seat = 97; seat < seatsInEvenRow; seat++)
                    {
                        Console.WriteLine($"{sectors}{rows}{(char)seat}");
                        counter++;
                    }
                }
                rowsInFirstSector++;
            }
            Console.WriteLine(counter);
        }
    }
}
