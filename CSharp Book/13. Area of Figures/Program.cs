using System;

namespace _13._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA * sideA);
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA * sideB);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(radius * radius * Math.PI);
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA * height / 2);
            }

        }
    }
}
