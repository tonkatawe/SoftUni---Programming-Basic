using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicFigure = int.Parse(Console.ReadLine());
            int figureStart = 0;
            int figureEnd = 0;
            int combination = 0;
            int counter = 0;
            for (figureStart = start; figureStart <= end; figureStart++)
            {
                for (figureEnd = start; figureEnd <= end; figureEnd++)
                {
                    counter++;
                    if (figureStart + figureEnd == magicFigure)
                    {



                        Console.WriteLine($"Combination N:{counter} ({figureStart} + {figureEnd} = {figureStart + figureEnd})");

                        return;

                    }
                    else
                    {
                        combination++;
                    }
                }

            }
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicFigure}");
            }
        }
    }
}
