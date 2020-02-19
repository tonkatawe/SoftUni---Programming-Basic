using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double grade = 0;
            while (counter <= 12)
            {
                double classGrade = double.Parse(Console.ReadLine());
                if (classGrade < 4)
                {
                    continue;
                }
                counter++;
                grade = grade + classGrade;
            }
            double average = grade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
        }
    }
}

