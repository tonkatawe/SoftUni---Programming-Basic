using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                savedMoney = 0;

                while (savedMoney < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }
                Console.WriteLine($"Going to {destination}!");
                budget = 0;
                destination = Console.ReadLine();

            }
        }
    }
}
