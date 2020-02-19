using System;

namespace _07._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double endprice = price * 7.61;
            double discount = (endprice * 18) / 100;
            double finalpricediscount = endprice - discount;
            Console.WriteLine("The final price is: {0:F2} lv.", finalpricediscount);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);
        }
    }
}