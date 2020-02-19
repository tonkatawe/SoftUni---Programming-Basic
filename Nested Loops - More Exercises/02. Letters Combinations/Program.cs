using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            int counter = 0;
            char check = 'a';
            for (char i = first; i <= second; i++)
            {

                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {

                        if ((k != third && i != third && j != third))
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.Write($"{counter}");
        }
    }
}
