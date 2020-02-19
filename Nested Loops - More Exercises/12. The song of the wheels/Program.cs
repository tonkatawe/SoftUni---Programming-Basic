using System;

namespace _12._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            bool check = false;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == num)
                            {
                                if (a < b && c > d)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    counter++;

                                }
                                if (counter == 4)
                                {
                                    e = a;
                                    f = b;
                                    g = c;
                                    h = d;
                                    check = true;
                                }

                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (check)
            {

                Console.WriteLine($"Password: {e}{f}{h}{g}");

            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
