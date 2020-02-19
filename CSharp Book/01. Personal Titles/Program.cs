using System;

namespace _01._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            if (gender == 'f')
            {
                if (age < 16 && age > 0)
                {
                    Console.WriteLine("Miss");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (gender == 'm')
                if (age < 16 && age > 0)
                {
                    Console.WriteLine("Master");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
        }
    }
}


