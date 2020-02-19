using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int capacityLibary = int.Parse(Console.ReadLine());
            int counter = 0;
            string input = "";
            while (counter < capacityLibary)
            {
                input = Console.ReadLine();
                if (input == bookName)
                {
                    break;
                }
                else if (counter >= capacityLibary)
                {
                    break;
                }
                counter++;

            }
            if (counter >= capacityLibary)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            else
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}
