using System;

namespace _05._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartPrice = 0;
            if (month == "May" || month == "October")
            {
                if (nights <= 7 && nights >= 0)
                {
                    studioPrice = nights * 50;
                    apartPrice = nights * 65;
                }

                else if ((nights > 7) && (nights < 14))
                {
                    studioPrice = (nights * 50) - (nights * 50) * 0.05;
                    apartPrice = nights * 65;
                }
                else if (nights > 14)
                {
                    studioPrice = (nights * 50) - (nights * 50) * 0.3;
                    apartPrice = (nights * 65) - (nights * 65) * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights >= 0 && nights < 14)
                {
                    studioPrice = nights * 75.2;
                    apartPrice = nights * 68.70;
                }
                if (nights > 14)
                {
                    studioPrice = (nights * 75.2) - (nights * 75.2) * 0.2;
                    apartPrice = (nights * 68.70) - (nights * 68.7) * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights >= 0)
                {
                    studioPrice = nights * 76;
                    apartPrice = nights * 77;
                }
                if (nights > 14)
                {
                    studioPrice = nights * 76;
                    apartPrice = (nights * 77) - (nights * 77) * 0.1;
                }

            }


            Console.WriteLine($"Apartment: {apartPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");


        }
    }
}

