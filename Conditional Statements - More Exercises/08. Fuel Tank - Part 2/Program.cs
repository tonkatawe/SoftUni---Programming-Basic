using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double countFuel = double.Parse(Console.ReadLine());
            string ownClubCard = Console.ReadLine();
            double discount = 0;
            double totalprice = 0.0;
            if (typeFuel == "Gas")
            {

                if (ownClubCard == "Yes")
                {
                    discount = 0.93 - 0.08;
                    totalprice = countFuel * discount;
                }
                else if (ownClubCard == "No")
                {

                    totalprice = countFuel * 0.93; ;
                }
            }
            else if (typeFuel == "Gasoline")
            {

                if (ownClubCard == "Yes")
                {
                    discount = 2.22 - 0.18;
                    totalprice = countFuel * discount;
                }
                else if (ownClubCard == "No")
                {

                    totalprice = 2.22 * countFuel;
                }
            }
            else if (typeFuel == "Diesel")
            {

                if (ownClubCard == "Yes")
                {
                    discount = 2.33 - 0.12;
                    totalprice = discount * countFuel;
                }
                else if (ownClubCard == "No")
                {

                    totalprice = 2.33 * countFuel;
                }
            }
            if (countFuel >= 20 && countFuel <= 25)
            {
                totalprice -= totalprice * 0.08;
            }
            else if (countFuel > 25)
            {
                totalprice -= totalprice * 0.1;
            }
            Console.WriteLine($"{totalprice:F2} lv.");
        }
    }
}
