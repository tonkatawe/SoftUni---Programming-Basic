using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int wide = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int area = wide * length;
            int input = 0;
            int sumPieces = 0;
            string pieces = string.Empty;
            while (sumPieces <= area)
            {
                pieces = Console.ReadLine();
                if (pieces == "STOP")
                {
                    break;
                }
                input = int.Parse(pieces);

                sumPieces += input;
            }
            if (pieces == "STOP")
            {
                Console.WriteLine($"{area - sumPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {sumPieces - area} pieces more.");
            }
        }
    }
}
