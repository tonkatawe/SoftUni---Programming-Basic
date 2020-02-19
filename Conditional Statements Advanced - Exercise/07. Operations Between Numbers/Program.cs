using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double num1 = double.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());
            double result = 0;
            string oddOrEven = "";
            if ((oper == '+' || oper == '-' || oper == '*') && (num > 0 && num1 > 0))
            {
                if (oper == '+')
                {
                    result = num + num1;
                }
                else if (oper == '-')
                {
                    result = num - num1;
                }
                else if (oper == '*')
                {
                    result = num * num1;
                }

                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                    Console.WriteLine($"{num} {oper} {num1} = {result} - {oddOrEven}");
                }
                else
                {
                    oddOrEven = "odd";
                    Console.WriteLine($"{num} {oper} {num1} = {result} - {oddOrEven}");
                }
            }
            if ((oper == '/') && (num > 0 && num1 > 0))
            {
                result = num / num1;
                Console.WriteLine($"{num} / {num1} = {result:F2}");

            }
            else if ((oper == '/' || oper == '%') && (num1 == 0))
            {
                Console.WriteLine($"Cannot divide {num} by zero");
            }
            if ((oper == '%') && (num > 0 && num1 > 0))
            {
                result = num % num1;
                Console.WriteLine($"{num} % {num1} = {result}");
            }
        }
    }
}

