using System;

namespace _06._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwod = Console.ReadLine();
            if (passwod == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}