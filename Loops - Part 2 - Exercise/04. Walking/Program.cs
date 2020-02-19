using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            double moresteps = 0;
            double sum = 0;
            while (sum < 10000)
            {
                string steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    moresteps = double.Parse(Console.ReadLine());
                    sum += moresteps;
                    break;
                }
                else
                {
                    moresteps = double.Parse(steps);
                    sum += moresteps;
                }
                if (sum >= 10000)
                {
                    break;
                }

            }
            if (sum >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {

                Console.WriteLine($"{10000 - sum} more steps to reach goal.");
            }
        }


    }
}

