using System;

namespace _08._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceHollyday = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int speakDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double sumToys = puzzles * 2.6 + speakDolls * 3 + teddyBears * 4.1 + minions * 8.2 + trucks * 2;
            int toysAmount = puzzles + speakDolls + teddyBears + minions + trucks;
            double discount = 0.0;
            if (toysAmount >= 50)
            {
                discount = sumToys * .25;
            }
            double totalprice = sumToys - discount;
            totalprice -= totalprice * 0.1;
            if (priceHollyday <= totalprice)
            {
                Console.WriteLine($"Yes! {(totalprice - priceHollyday):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceHollyday - totalprice):F2} lv needed.");
            }
        }
    }



}




