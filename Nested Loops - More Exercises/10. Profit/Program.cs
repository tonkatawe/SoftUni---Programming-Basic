using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinOne = int.Parse(Console.ReadLine());
            int coinTwo = int.Parse(Console.ReadLine());
            int notesFive = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int counterOne = 1;
            int counterTwo = 2;
            int counterNotice = 5;
            for (int i = 0; i <= coinOne; i++)
            {

                for (int j = 0; j <= coinTwo; j++)
                {
                    for (int l = 0; l <= notesFive; l++)
                    {
                        if (i * counterOne + j * counterTwo + l * counterNotice == sum)
                        {

                            Console.Write($"{i} * 1 lv. + {j} * 2 lv. + {l} * 5 lv. = {sum} lv.");

                            Console.WriteLine();

                        }

                    }

                }


            }

        }
    }
}
