using System;

namespace _11._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeOfProjection = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColomus = int.Parse(Console.ReadLine());
            double primiere = 12;
            double Normal = 7.50;
            double Discount = 5;
            double earnings = 0;
            if (typeOfProjection == "Premiere")
            {
                earnings = numberOfColomus * numberOfRows * 12;
                Console.WriteLine($"{earnings:F2}");
            }
            else if (typeOfProjection == "Normal")
            {
                earnings = numberOfColomus * numberOfRows * 7.50;
                Console.WriteLine($"{earnings:F2}");
            }
            else if (typeOfProjection == "Discount")
            {
                earnings = numberOfColomus * numberOfRows * 5;
                Console.WriteLine($"{earnings:F2}");
            }
        }
    }
}

