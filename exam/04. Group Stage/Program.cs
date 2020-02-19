using System;

namespace _04._Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int countMuch = int.Parse(Console.ReadLine());
            int counter = 0;
            int goIn = 0;
            int goOut = 0;
            int pointIn = 0;
            int pointOut = 0;
            int sum = 0;
            while (counter != countMuch)
            {
                counter++;
                goIn = int.Parse(Console.ReadLine());
                goOut = int.Parse(Console.ReadLine());
                if (goIn > goOut)
                {
                    pointIn += goIn;
                    pointOut += goOut;
                    sum += 3;
                }
                if (goIn == goOut)
                {
                    pointIn += goIn;
                    pointOut += goOut;
                    sum += 1;
                }
                if (goIn < goOut)
                {
                    pointIn += goIn;
                    pointOut += goOut;
                }

            }
            int rest = pointIn - pointOut;
            if (pointIn >= pointOut)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {sum} points.");
                Console.WriteLine($"Goal difference: {rest}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {rest}.");
            }
         }
    }
}
