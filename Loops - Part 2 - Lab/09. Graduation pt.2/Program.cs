using System;

namespace _09._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            double grade = 0;
            int counter = 1;
            int count2 = 1;
            while (counter <= 12)
            {

                double classGrade = double.Parse(Console.ReadLine());

                if (classGrade < 4)
                {
                    count2++;

                }
                if (count2 == 3)
                {
                    break;
                }
                counter++;
                grade = grade + classGrade;
            }
            if (count2 == 3)
            {
                Console.WriteLine($"{name} has been excluded at {counter - 1} grade");
            }
            else
            {
                double average = grade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
        }
    }
}

