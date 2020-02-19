using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirthSeconds = int.Parse(Console.ReadLine());
            int totaltime = firstSeconds + secondSeconds + thirthSeconds;
            double minutes = totaltime / 60;
            double rest = totaltime % 60;
            if (rest < 10)
            {
                Console.WriteLine($"{minutes}:0{rest}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{rest}");
            }
        }

    }
}
