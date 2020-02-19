using System;

namespace _04._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int people = 0;
            double sum = 0;
            int counter = 0;
            while (command != "Movie time!")
            {
                people = int.Parse(command);
                counter += people;
                if (counter > capacity)
                {
                    break;
                }
                if (people % 3 == 0)
                {
                    sum += people * 5 - 5;
                }
                else
                {
                    sum += people * 5;
                }
                command = Console.ReadLine();
            }
            if (counter > capacity)
            {
                Console.WriteLine("The cinema is full.");
            }
            else
            {
                double restSeats = capacity - counter;
                Console.WriteLine($"There are {restSeats} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {sum} lv.");
        }
    }
}
