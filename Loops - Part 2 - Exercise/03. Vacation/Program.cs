using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int counter = 0;
            int spendCounter = 0;
            while (availableMoney < neededMoney && spendCounter < 5)
            {
                string spendOrSave = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (spendOrSave == "spend")
                {
                    if (money > availableMoney)
                    {
                        availableMoney = 0;
                    }
                    else
                    {
                        availableMoney = availableMoney - money;
                    }
                    spendCounter++;
                }
                else if (spendOrSave == "save")
                {
                    availableMoney += money;
                    spendCounter = 0;
                }

                counter++;

            }
            if (spendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{counter}");
            }
            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {counter} days.");
            }

        }
    }
}

