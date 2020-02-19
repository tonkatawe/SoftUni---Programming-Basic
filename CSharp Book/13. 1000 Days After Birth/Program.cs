using System;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime data2 = date.AddDays(1000);
            Console.WriteLine(data2.ToString("dd-MM-yyyy"));
        }
    }
}
