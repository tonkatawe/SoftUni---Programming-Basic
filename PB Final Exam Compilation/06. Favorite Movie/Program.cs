using System;

namespace _06._Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int counter = 0;
            int points = 0;
            int sum = 0;
            int maxPoint = int.MinValue;
            string bestFilm = string.Empty;
            while (command != "STOP" || counter == 7)
            {
                counter++;
                if (counter == 7)
                {
                    break;
                }
                int lenght = command.Length;
                for (int i = 0; i < command.Length; i++)
                {
                    char letter = command[i];
                    if (letter >= 65 && letter <= 87)
                    {
                        points = letter - lenght;
                    }
                    if (letter >= 97 && letter <= 122)
                    {
                        points = letter - 2 * lenght;
                    }
                    if (letter == 32)
                    {
                        points = letter;
                    }
                    sum += points;
                    if (sum > maxPoint)
                    {
                        maxPoint = sum;
                        bestFilm = command;
                    }
                    points = 0;
                }
                sum = 0;
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                Console.WriteLine($"The best movie for you is {bestFilm} with {maxPoint} ASCII sum.");
            }
            if (counter == 7)
            {
                Console.WriteLine("The limit is reached.");
                Console.WriteLine($"The best movie for you is {bestFilm} with {maxPoint} ASCII sum.");
            }
        }
    }
}

