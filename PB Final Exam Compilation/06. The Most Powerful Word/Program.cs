using System;

namespace _06._The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double currentSum = 0;
            char firstLetter = '0';
            double totalsum = 0;
            double maxWord = double.MinValue;
            string word = string.Empty;
            while (command != "End of words")
            {
                double lenght = command.Length;
                for (int i = 0; i < command.Length; i++)
                {
                    char letter = command[i];
                    if (i == 0)
                    {
                        firstLetter = (char)letter;
                    }
                    currentSum += letter;
                }
                if (firstLetter == 'a' || firstLetter == 'e' || firstLetter == 'i' || firstLetter == 'o' || firstLetter == 'u' || firstLetter == 'y' || firstLetter == 'A' || firstLetter == 'E' || firstLetter == 'I' || firstLetter == 'O' || firstLetter == 'U' || firstLetter == 'Y')
                {
                    totalsum = currentSum * lenght;
                }
                else
                {
                    totalsum = Math.Floor(currentSum / lenght);
                }
                if (totalsum > maxWord)
                {
                    maxWord = totalsum;
                    word = command;
                }
                currentSum = 0;
                command = Console.ReadLine();

            }
            Console.WriteLine($"The most powerful word is {word} - {maxWord}");
        }
    }
}

