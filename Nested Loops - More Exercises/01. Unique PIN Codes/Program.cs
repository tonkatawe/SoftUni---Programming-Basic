using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            for (int firstNum = 2; firstNum <= num1; firstNum += 2)
            {
                for (int secondNum = 2; secondNum <= num2; secondNum++)
                {
                    for (int thirdNum = 2; thirdNum <= num3; thirdNum += 2)
                    {
                        if (secondNum == 2 || secondNum == 3 || secondNum == 5 || secondNum == 7)
                        {
                            Console.WriteLine($"{firstNum} {secondNum} {thirdNum}");
                        }
                    }
                }
            }

        }
    }
}
