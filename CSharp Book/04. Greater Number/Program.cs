using System;

namespace _04._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            double grade2 = double.Parse(Console.ReadLine());
            if (grade > grade2)
            {
                Console.WriteLine(grade);
            }
            else
            {
                Console.WriteLine(grade2);
            }
        }
    }
}
