using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double firstGrades = 0;
            double secondGrades = 0;
            double thirthGrades = 0;
            double fourthGrades = 0;
            double averrageSum = 0;
            for (int i = 0; i < n; i++)
            {
                double grades = double.Parse(Console.ReadLine());
                if (grades >= 2 && grades <= 2.99)
                {
                    firstGrades++;
                    averrageSum += grades;
                }
                if (grades >= 3 && grades <= 3.99)
                {
                    secondGrades++;
                    averrageSum += grades;
                }
                if (grades >= 4 && grades <= 4.99)
                {
                    thirthGrades++;
                    averrageSum += grades;
                }
                if (grades >= 5.00)
                {
                    fourthGrades++;
                    averrageSum += grades;
                }
            }
            double top = fourthGrades / n * 100;
            double good = thirthGrades / n * 100;
            double bad = secondGrades / n * 100;
            double fail = firstGrades / n * 100;
            averrageSum = averrageSum / n;
            Console.WriteLine($"Top students: {top:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {good:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {bad:F2}%");
            Console.WriteLine($"Fail: {fail:F2}%");
            Console.WriteLine($"Average: {averrageSum:F2}");
        }
    }
}
