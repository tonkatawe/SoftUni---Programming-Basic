using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int countHoliday = int.Parse(Console.ReadLine());
            int counWeeks = int.Parse(Console.ReadLine());
            double weekInSf = 48 - counWeeks;
            double playsSofia = weekInSf * (3.0 / 4);
            double playSunday = 2;
            double playHoliday = countHoliday * (2.0 / 3);
            double total = 0;
            if (year == "normal")
            {
                total = (playHoliday + playsSofia + counWeeks);
            }
            else if (year == "leap")
            {
                total = (playHoliday + playsSofia + counWeeks);
                total += total * 0.15;
            }
            Console.WriteLine(Math.Floor(total));
        }
    }
}
