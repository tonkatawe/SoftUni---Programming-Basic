using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string location = "";
            string typeACC = "";
            if (season == "Summer")
            {
                location = "Alaska";
                if (buget <= 1000)
                {

                    typeACC = "Camp";
                    price = buget * 0.65;
                }
                else if (buget > 1000 && buget <= 3000)
                {
                    typeACC = "Hut";
                    price = buget * 0.8;
                }
                else if (buget > 3000)
                {
                    typeACC = "Hotel";
                    price = buget * 0.9;
                }

            }
            else if (season == "Winter")
            {
                location = "Morocco";
                if (buget <= 1000)
                {
                    typeACC = "Camp";
                    price = buget * 0.45;
                }
                else if (buget > 1000 && buget <= 3000)
                {
                    typeACC = "Hut";
                    price = buget * 0.6;
                }
                else if (buget > 3000)
                {
                    typeACC = "Hotel";
                    price = buget * 0.9;
                }

            }
            Console.WriteLine($"{location} - {typeACC} - {price:F2}");
        }
    }
}
