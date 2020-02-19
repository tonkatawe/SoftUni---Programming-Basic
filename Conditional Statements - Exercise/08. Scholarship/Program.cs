using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double earnings = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());
            double socialScholarship = Math.Floor(minimumSalary * 0.35);
            double excellentScholarship = Math.Floor(averageGrade * 25);
            if (earnings <= minimumSalary)
            {
                if (averageGrade >= 4.50 && averageGrade < 5.50)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else if (averageGrade >= 5.50 && excellentScholarship >= socialScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You cannot get a scholarship!");
                }

            }
            else if (earnings > minimumSalary && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }


        }
    }
}