using System;

namespace _05._PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            int counter = 0;
            double hearthstone = 0;
            double fornite = 0;
            double overwatch = 0;
            double others = 0;

            for (int i = 0; i < games; i++)
            {
                counter++;
                string nameGame = Console.ReadLine();
                if (nameGame == "Hearthstone")
                {
                    hearthstone++;
                }
                if (nameGame == "Fornite")
                {
                    fornite++;
                }
                if (nameGame == "Overwatch")
                {
                    overwatch++;
                }
                if (nameGame != "Hearthstone" && nameGame != "Fornite" && nameGame != "Overwatch")
                {
                    others++;
                }
            }
            Console.WriteLine($"Hearthstone - {(hearthstone / counter * 100):F2}%");
            Console.WriteLine($"Fornite - {(fornite / counter * 100):F2}%");
            Console.WriteLine($"Overwatch - {(overwatch / counter * 100):F2}%");
            Console.WriteLine($"Others - {(others / counter * 100):F2}%");
        }
    }
}

