using System;

namespace _06._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            double points = 0.0;

            if (grade % 10 == 5)
            {
                points = points + 2;

            }
            if (grade % 2 == 0)
            {
                points = points + 1;
            }
            if (grade <= 100)
            {
                double points2 = points + 5;
                Console.WriteLine(points2);
                Console.WriteLine(points2 + grade);
            }
            if (grade > 100 && grade < 1000)
            {
                double points4 = points + 0.2 * grade;
                Console.WriteLine(points4);
                Console.WriteLine(points4 + grade);
            }
            if (grade > 1000)
            {
                double points3 = points + 0.1 * grade;
                Console.WriteLine(points3);
                Console.WriteLine(points3 + grade);
            }

            {

            }
        }
    }
}

