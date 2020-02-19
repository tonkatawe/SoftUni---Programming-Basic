using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int load = int.Parse(Console.ReadLine());
            double countBus = 0;
            double countLorry = 0;
            double countTrain = 0;
            double totalTons = 0;
            double bus = 0;
            double lorry = 0;
            double train = 0;
            double average = 0;
            for (int i = 0; i < load; i++)
            {
                double tons = double.Parse(Console.ReadLine());
                if (tons <= 3)
                {
                    bus += tons;
                }
                if (tons >= 4 && tons <= 11)
                {
                    lorry += tons;
                }
                if (tons >= 12)
                {
                    train += tons;
                }
                totalTons += tons;
            }
            average = (bus * 200 + lorry * 175 + train * 120) / totalTons;
            countBus = bus / totalTons * 100;
            countLorry = lorry / totalTons * 100;
            countTrain = train / totalTons * 100;
            Console.WriteLine($"{average:F2}");
            Console.WriteLine($"{countBus:F2}%");
            Console.WriteLine($"{countLorry:F2}%");
            Console.WriteLine($"{countTrain:F2}%");
        }
    }
}
