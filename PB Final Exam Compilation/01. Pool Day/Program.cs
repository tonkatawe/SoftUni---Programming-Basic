using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double ticket = double.Parse(Console.ReadLine());
            double priceChair = double.Parse(Console.ReadLine());
            double priceUmbrela = double.Parse(Console.ReadLine());
            double allTicket = people * ticket;
            double wantChairs = Math.Ceiling(people * 0.75);
            double allChairs = (wantChairs * priceChair);
            double neededUmbrelas = Math.Ceiling(people * 0.5);
            double allUmbrelas = neededUmbrelas * priceUmbrela;
            double total = allChairs + allTicket + allUmbrelas;
            Console.WriteLine($"{total:F2} lv.");

        }
    }
}