using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int waste = 0;
            for (int i = 0; i < tabs; i++)
            {
                string web = Console.ReadLine();
                if (web == "Facebook")
                {
                    waste += 150;
                    if (salary - waste <= 0)
                    {
                        break;
                    }
                }
                if (web == "Instagram")
                {
                    waste += 100;
                    if (salary - waste <= 0)
                    {
                        break;
                    }
                }
                if (web == "Reddit")
                {
                    waste += 50;
                    if (salary - waste <= 0)
                    {
                        break;
                    }

                }
            }
            int rest = salary - waste;
            if (rest > 0)
            {

                Console.WriteLine(rest);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}

