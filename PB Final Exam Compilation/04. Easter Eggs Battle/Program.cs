using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsPlayerOne = int.Parse(Console.ReadLine());
            int eggsPlayerTwo = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "End of battle")
            {
                if (command == "one")
                {
                    eggsPlayerTwo -= 1;
                }
                if (command == "two")
                {
                    eggsPlayerOne -= 1;
                }
                if (eggsPlayerOne == 0 || eggsPlayerTwo == 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (eggsPlayerOne == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {eggsPlayerTwo} eggs left.");
            }
            if (eggsPlayerTwo == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {eggsPlayerOne} eggs left.");
            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Player one has {eggsPlayerOne} eggs left.");
                Console.WriteLine($"Player two has {eggsPlayerTwo} eggs left.");
            }
        }
    }
}

