using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int pupil = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            string sportType = "";
            if (season == "Winter")
            {
                if (typeOfGroup == "girls" || typeOfGroup == "boys")
                {
                    price = nights * pupil * 9.6;
                    if (typeOfGroup == "girls")
                    {
                        sportType = "Gymnastics";
                    }
                    else if (typeOfGroup == "boys")
                    {
                        sportType = "Judo";
                    }
                }
                else if (typeOfGroup == "mixed")
                {
                    price = nights * pupil * 10;
                    sportType = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (typeOfGroup == "girls" || typeOfGroup == "boys")
                {
                    price = nights * pupil * 7.2;
                    if (typeOfGroup == "girls")
                    {
                        sportType = "Athletics";
                    }
                    else if (typeOfGroup == "boys")
                    {
                        sportType = "Tennis";
                    }
                }
                else if (typeOfGroup == "mixed")
                {
                    price = nights * pupil * 9.5;
                    sportType = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (typeOfGroup == "girls" || typeOfGroup == "boys")
                {
                    price = nights * pupil * 15;
                    if (typeOfGroup == "girls")
                    {
                        sportType = "Volleyball";
                    }
                    else if (typeOfGroup == "boys")
                    {
                        sportType = "Football";
                    }
                }
                else if (typeOfGroup == "mixed")
                {
                    price = nights * pupil * 20;
                    sportType = "Swimming";
                }
            }
            if (pupil >= 0)
            {
                price = price;
                if (pupil >= 50)
                {
                    price -= price * 0.5;
                }
                else if (pupil >= 20 && pupil < 50)
                {
                    price -= price * 0.15;
                }
                else if (pupil < 20 && pupil >= 10)
                {
                    price -= price * 0.05;
                }
            }
            Console.WriteLine($"{sportType} {price:F2} lv.");
        }
    }
}
