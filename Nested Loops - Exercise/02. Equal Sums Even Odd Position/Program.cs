using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int evenSum = 0;
                int OddSum = 0;
                string numAssStr = i.ToString();
                for (int j = 0; j < numAssStr.Length; j++)
                {

                    if (j % 2 == 0)
                    {
                        OddSum += int.Parse(numAssStr[j].ToString());
                    }
                    else
                    {
                        evenSum += int.Parse(numAssStr[j].ToString());

                    }
                }
                if (evenSum == OddSum)
                {
                    Console.Write(numAssStr + " ");
                }
            }
        }
    }
}
