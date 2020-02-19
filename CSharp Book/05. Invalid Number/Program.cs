using System;

namespace _05._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool chek = ((num >= 100 && num <= 200) || num == 0);
            if (!chek)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
