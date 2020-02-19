using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            double studentFinalAssesment = 0;
            double currentGrade = 0;
            int countPresentation = 0;
            while (nameOfPresentation != "Finish")
            {
                double avarrageCurrent = 0;
                double grade = 0;
                currentGrade = 0;
                for (int i = 0; i < people; i++)
                {

                    grade = double.Parse(Console.ReadLine());
                    currentGrade += grade;
                    studentFinalAssesment += grade;
                    countPresentation++;
                }
                avarrageCurrent = currentGrade / people;
                Console.WriteLine($"{nameOfPresentation} - {(currentGrade / people):F2}.");
                nameOfPresentation = Console.ReadLine();
            }
            double avarregeGrade = studentFinalAssesment / countPresentation;
            Console.WriteLine($"Student's final assessment is {avarregeGrade:F2}.");
        }
    }
}
