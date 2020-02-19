using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int intHours = int.Parse(Console.ReadLine());
            int intMinutes = int.Parse(Console.ReadLine());
            int minutes = intHours * 60 + intMinutes;
            minutes += 15;
            int outHours = minutes / 60;
            int outMinutes = minutes % 60;
            if (outHours > 23)
            {
                outHours = outHours - 24;
            }
            if (outMinutes < 10)
            {
                Console.WriteLine($"{outHours}:0{outMinutes}");
            }
            else
            {
                Console.WriteLine($"{outHours}:{outMinutes}");
            }

        }
    }
}

