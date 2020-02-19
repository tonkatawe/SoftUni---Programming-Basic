using System;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPass = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char firstSym = (char)35; firstSym <= (char)55; firstSym++)
            {
                for (char secondSym = (char)64; secondSym <= (char)96; secondSym++)
                {
                    for (int thirdSym = 1; thirdSym <= a; thirdSym++)
                    {

                        for (int fourthSym = 1; fourthSym <= b; fourthSym++)
                        {
                            Console.Write($"{firstSym}{secondSym}{thirdSym}{fourthSym}{secondSym}{firstSym}|");
                            counter++;
                            if ((counter == maxPass) || (thirdSym == a && fourthSym == b))
                            {
                                return;
                            }
                            if (firstSym == (char)55)
                            {
                                firstSym = (char)35;
                            }
                            if (secondSym == (char)96)
                            {
                                secondSym = (char)64;
                            }
                            firstSym++;
                            secondSym++;
                        }
                    }
                }
            }
        }
    }
}
