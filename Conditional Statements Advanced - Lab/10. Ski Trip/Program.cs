using System;

namespace _10._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfHoliday = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0.0;
            double discount = 0;
            int nights = dayOfHoliday - 1;

            if (typeOfRoom == "room for one person")
            {
                if (grade == "positive")
                {
                    price = (nights * 18) * 0.25 + nights * 18;
                }
                else if (grade == "negative")
                {
                    price = nights * 18 - (nights * 18) * 0.1;
                }
            }
            else if (typeOfRoom == "apartment" && dayOfHoliday < 10)
            {
                discount = (nights * 25) * 0.3;
                if (grade == "positive")
                {
                    price = (nights * 25) - discount + (nights * 25 - discount) * 0.25;
                }
                else if (grade == "negative")
                {
                    price = (nights * 25) - discount - (nights * 25 - discount) * 0.1;
                }
            }
            else if (typeOfRoom == "apartment" && dayOfHoliday <= 15 && dayOfHoliday >= 10)
            {
                discount = (nights * 25) * 0.35;
                if (grade == "positive")
                {
                    price = (nights * 25) - discount + (nights * 25 - discount) * 0.25;
                }
                else if (grade == "negative")
                {
                    price = (nights * 25) - discount - (nights * 25 - discount) * 0.1;
                }
            }
            else if (typeOfRoom == "apartment" && dayOfHoliday > 15)
            {
                discount = (nights * 25) * 0.5;
                if (grade == "positive")
                {
                    price = (nights * 25) - discount + (nights * 25 - discount) * 0.25;
                }
                else if (grade == "negative")
                {
                    price = (nights * 25) - discount - (nights * 25 - discount) * 0.1;
                }
            }
            else if (typeOfRoom == "president apartment" && dayOfHoliday < 10)
            {
                discount = (nights * 35) * 0.1;
                if (grade == "positive")
                {
                    price = (nights * 35) - discount + (nights * 25 - discount) * 0.25;
                }
                else if (grade == "negative")
                {
                    price = (nights * 35) - discount - (nights * 25 - discount) * 0.1;
                }
            }
            else if (typeOfRoom == "president apartment" && dayOfHoliday <= 15 && dayOfHoliday >= 10)
            {
                discount = (nights * 35) * 0.15;
                if (grade == "positive")
                {
                    price = (nights * 35) - discount + (nights * 35 - discount) * 0.25;
                }
                else if (grade == "negative")
                {
                    price = (nights * 35) - discount - (nights * 35 - discount) * 0.1;
                }
            }
            else if (typeOfRoom == "president apartment" && dayOfHoliday > 15)
            {
                discount = (nights * 35) * 0.2;
                if (grade == "positive")
                {
                    price = (nights * 35) - discount + (nights * 35 - discount) * 0.25;
                }
                else if (grade == "negative")
                {
                    price = (nights * 35) - discount - (nights * 35 - discount) * 0.1;
                }
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}

