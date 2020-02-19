using System;

namespace _04._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int buget = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            if (typeOfFlowers == "Roses")
            {

                if (quantity <= 80)
                {
                    price = quantity * 5;
                }
                else if (quantity > 80)
                {
                    discount = (quantity * 5) * 0.1;
                    price = quantity * 5 - discount;
                }

            }
            else if (typeOfFlowers == "Dahlias")
            {

                if (quantity <= 90)
                {
                    price = quantity * 3.8;
                }
                else if (quantity > 90)
                {
                    discount = (quantity * 3.8) * 0.15;
                    price = quantity * 3.8 - discount;
                }

            }
            else if (typeOfFlowers == "Tulips")
            {

                if (quantity <= 80)
                {
                    price = quantity * 2.8;
                }
                else if (quantity > 80)
                {
                    discount = (quantity * 2.8) * 0.15;
                    price = quantity * 2.8 - discount;
                }

            }
            else if (typeOfFlowers == "Narcissus")
            {

                if (quantity >= 120)
                {
                    price = quantity * 3;
                }
                else if (quantity < 120)
                {
                    discount = (quantity * 3) * 0.15;
                    price = quantity * 3 + discount;
                }

            }

            else if (typeOfFlowers == "Gladiolus")
            {

                if (quantity >= 80)
                {
                    price = quantity * 2.5;
                }
                else if (quantity < 80)
                {
                    discount = (quantity * 2.5) * 0.2;
                    price = quantity * 2.5 + discount;
                }

            }
            if (price > buget)
            {

                Console.WriteLine($"Not enough money, you need {(price - buget):F2} leva more.");

            }
            else
            {

                Console.WriteLine($"Hey, you have a great garden with {quantity} {typeOfFlowers} and {(buget - price):F2} leva left.");


            }

        }
    }
}

