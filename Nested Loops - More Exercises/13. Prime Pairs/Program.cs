using System;

namespace _13._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCouple = int.Parse(Console.ReadLine());
            int secondCouple = int.Parse(Console.ReadLine());
            int endFirst = int.Parse(Console.ReadLine());
            int endSecond = int.Parse(Console.ReadLine());
            for (int first = firstCouple; first <= firstCouple + endFirst; first++)
                for (int second = secondCouple; second <= secondCouple + endSecond; second++)
                {
                    if ((first % 2 == 1 && first % 5 != 0 && first % 3 != 0) && (second % 2 == 1 && second % 3 != 0 && second % 5 != 0 && second % 7 != 0))
                        Console.WriteLine($"{first}{second} ");
                }
        }
    }
}
