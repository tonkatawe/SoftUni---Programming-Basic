using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightNum = 0;
            int leftNum = 0;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                rightNum += current;
            }
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                leftNum += current;
            }
            if (rightNum == leftNum)
            {

                Console.WriteLine($"Yes, sum = {rightNum}");
            }
            if (rightNum != leftNum)
            {
                int diff = Math.Abs(rightNum - leftNum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
