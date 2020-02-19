using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int avaibleDay = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            double educate = avaibleDay * 0.1;
            double realhours = (avaibleDay - educate) * 8;
            double overtime = countWorkers * 2 * avaibleDay;
            double totalHours = Math.Floor(realhours + overtime);
            if (totalHours >= neededHours)
            {
                Console.WriteLine($"Yes!{totalHours - neededHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Abs(totalHours - neededHours)} hours needed.");
            }
        }
    }
}
