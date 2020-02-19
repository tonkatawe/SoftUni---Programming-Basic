using System;

namespace _05._Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDaysMonth = int.Parse(Console.ReadLine());
            double earnMoneyDay = double.Parse(Console.ReadLine());
            double dollarcourse = double.Parse(Console.ReadLine());
            double monthsalary = workDaysMonth * earnMoneyDay;
            double yearsalary = monthsalary * 12 + 2.5 * monthsalary;
            double tax = yearsalary * 0.25;
            double clearsalary = yearsalary - tax;
            double salaryLvPerDay = clearsalary * dollarcourse / 365;
            Console.WriteLine($"{salaryLvPerDay:F2}");
        }
    }
}