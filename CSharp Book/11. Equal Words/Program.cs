using System;

namespace _11._Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();
            if (first == second)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
