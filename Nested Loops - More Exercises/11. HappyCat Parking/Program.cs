using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double evenDay = 0;
            double totalPerDay = 0;
            int counter = 0;
            double oddDay = 0;
            double total = 0;
            double price = 0;
            for (int day = 1; day <= days; day++)
            {
                evenDay = 0;
                oddDay = 0;
                price = 0;
                totalPerDay = 0;
                counter++;
                for (int hour = 1; hour <= hours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 == 1)
                    {
                        evenDay += 2.5;
                    }
                    else if (day % 2 == 1 && hour % 2 == 0)
                    {
                        oddDay += 1.25;
                    }
                    else
                    {
                        price += 1;
                    }
                    totalPerDay = evenDay + oddDay + price;

                }
                total += totalPerDay;
                Console.WriteLine($"Day: {counter} - {totalPerDay:F2} leva");
            }

            Console.WriteLine($"Total: {total:F2} leva");
        }
    }
}
