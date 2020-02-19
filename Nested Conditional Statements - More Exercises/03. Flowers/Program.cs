using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countHrisentemus = int.Parse(Console.ReadLine());
            int countRouses = int.Parse(Console.ReadLine());
            int countTulips = int.Parse(Console.ReadLine());
            string session = Console.ReadLine();
            string dayOrNot = Console.ReadLine();
            double priceHrisentemus = 0;
            double priceRouses = 0;
            double priceTulips = 0;
            double totalPrice = 0;
            double discount = 0;
            if (session == "Spring" || session == "Summer")
            {
                priceHrisentemus = 2;
                priceRouses = 4.1;
                priceTulips = 2.5;
                totalPrice = countHrisentemus * priceHrisentemus + countRouses * priceRouses + countTulips * priceTulips;
                if (dayOrNot == "Y")
                {
                    discount = (countHrisentemus * priceHrisentemus + countRouses * priceRouses + countTulips * priceTulips) * 0.15;
                    totalPrice = countHrisentemus * priceHrisentemus + countRouses * priceRouses + countTulips * priceTulips + discount;
                }

                if (session == "Spring" && countTulips > 7)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }
            if (session == "Autumn" || session == "Winter")
            {
                priceHrisentemus = 3.75;
                priceRouses = 4.50;
                priceTulips = 4.15;
                if (dayOrNot == "Y")
                {
                    priceHrisentemus += priceHrisentemus * 0.15;
                    priceRouses += priceRouses * 0.15;
                    priceTulips += priceTulips * 0.15;
                }
                totalPrice = countHrisentemus * priceHrisentemus + countRouses * priceRouses + countTulips * priceTulips;
                if (session == "Winter" && countRouses >= 10)
                {
                    totalPrice -= totalPrice * 0.1;
                }
            }
            if ((countRouses + countHrisentemus + countTulips) > 20)
            {
                totalPrice -= totalPrice * 0.2;
            }
            Console.WriteLine($"{(totalPrice + 2):F2}");


        }
    }
}
