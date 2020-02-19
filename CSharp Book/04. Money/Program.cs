using System;

namespace _04._Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountBitCoin = int.Parse(Console.ReadLine());
            double amountChineseIen = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            int bitcoin = 1168;
            double chineion = 0.15;
            double dolar = 1.76;
            double euro = 1.95;
            double bitcoinineuro = bitcoin / euro;
            double dolarineuro = dolar / euro;
            double ionineuro = dolarineuro * chineion;
            double sumBitinEuro = amountBitCoin * bitcoinineuro;
            double sumIon = amountChineseIen * ionineuro;
            double sumcommission = ((sumBitinEuro + sumIon) * commission) / 100;
            double total = sumBitinEuro + sumIon - sumcommission;
            Console.WriteLine($"{total}");
        }
    }
}

