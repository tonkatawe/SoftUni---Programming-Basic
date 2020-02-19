using System;

namespace _03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfDrink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int amountDrinks = int.Parse(Console.ReadLine());
            double price = 0;
            if (nameOfDrink == "Espresso")
            {
                if (sugar == "Without")
                {
                    price = amountDrinks * 0.9 - (amountDrinks * 0.9) * 0.35;
                }
                if (sugar == "Normal")
                {
                    price = amountDrinks * 1;
                }
                if (sugar == "Extra")
                {
                    price = amountDrinks * 1.2;
                }
                if (amountDrinks >= 5)
                {
                    price = price - price * 0.25;
                }
            }
            if (nameOfDrink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    price = amountDrinks * 1 - (amountDrinks * 1) * 0.35;
                }
                if (sugar == "Normal")
                {
                    price = amountDrinks * 1.2;
                }
                if (sugar == "Extra")
                {
                    price = amountDrinks * 1.6;
                }
            }
            if (nameOfDrink == "Tea")
            {
                if (sugar == "Without")
                {
                    price = amountDrinks * 0.5 - (amountDrinks * 0.5) * 0.35;
                }
                if (sugar == "Normal")
                {
                    price = amountDrinks * 0.6;
                }
                if (sugar == "Extra")
                {
                    price = amountDrinks * 0.7;
                }
            }
            if (price > 15)
            {
                price = price - price * 0.2;
            }
            Console.WriteLine($"You bought {amountDrinks} cups of {nameOfDrink} for {price:F2} lv.");
        }
    }
}

