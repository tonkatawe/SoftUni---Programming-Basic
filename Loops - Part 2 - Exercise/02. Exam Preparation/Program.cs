using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double badGrade = double.Parse(Console.ReadLine());
            double problems = 0;
            double counter = 0;
            string lastname = string.Empty;
            double sumgrades = 0;
            string nameOfEx = Console.ReadLine();
            while (nameOfEx != "Enough")
            {
                double gradeByEx = double.Parse(Console.ReadLine());
                lastname = nameOfEx;
                sumgrades = sumgrades + gradeByEx;
                if (gradeByEx <= 4)
                {
                    problems++;

                }
                counter++;
                if (problems == badGrade)
                {
                    break;
                }
                nameOfEx = Console.ReadLine();
            }
            if (problems == badGrade)
            {
                Console.WriteLine($"You need a break, {badGrade} poor grades.");
            }
            else
            {
                double average = sumgrades / counter * 1.0;
                Console.WriteLine($"Average score: {average:F2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastname}");
            }
        }
    }
}
