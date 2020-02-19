using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {

            int buget = int.Parse(Console.ReadLine());
            string seassion = Console.ReadLine();
            int fishmen = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            if (seassion == "Spring")
            {
                price = 3000;
                if (fishmen <= 6)
                {
                    discount = price * 0.1;
                    price = price - discount;
                }
                else if (fishmen > 7 && fishmen <= 11)
                {
                    discount = price * 0.15;
                    price = price - discount;
                }
                else if (fishmen > 12)
                {
                    discount = price * 0.25;
                    price = price - discount;
                }
            }
            else if (seassion == "Summer" || seassion == "Autumn")
            {
                price = 4200;
                if (fishmen <= 6)
                {
                    discount = price * 0.1;
                    price = price - discount;
                }
                else if (fishmen > 7 && fishmen <= 11)
                {
                    discount = price * 0.15;
                    price = price - discount;
                }
                else if (fishmen >= 12)
                {
                    discount = price * 0.25;
                    price = price - discount;
                }
            }
            else if (seassion == "Winter")
            {
                price = 2600;
                if (fishmen <= 6)
                {
                    discount = price * 0.1;
                    price = price - discount;
                }
                else if (fishmen > 7 && fishmen <= 11)
                {
                    discount = price * 0.15;
                    price = price - discount;
                }
                else if (fishmen >= 12)
                {
                    discount = price * 0.25;
                    price = price - discount;
                }
            }
            if ((seassion == "Winter" || seassion == "Summer" || seassion == "Spring") && (fishmen % 2 == 0))
            {
                price -= price * 0.05;
            }
            if (price > buget)
            {
                Console.WriteLine($"Not enough money! You need {(price - buget):F2} leva.");
            }
            else if (price <= buget)
            {
                Console.WriteLine($"Yes! You have {(buget - price):F2} leva left.");
            }

        }
    }
}

}
