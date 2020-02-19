using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for (int firstNum = 1; firstNum < 9; firstNum++)
            {
                for (int secondNum = 1; secondNum < 9; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum < 9; thirdNum++)
                    {

                        for (int fourthNum = 1; fourthNum < 9; fourthNum++)
                        {
                            if (num % firstNum == 0 && num % secondNum == 0 && num % thirdNum == 0 && num % fourthNum == 0)
                            {
                                Console.Write($"{firstNum}{secondNum}{thirdNum}{fourthNum} ");
                            }

                        }
                    }
                }
            }
        }
    }
}





