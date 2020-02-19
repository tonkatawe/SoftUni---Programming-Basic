using System;

namespace _04._Triangle_of_55_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                char a = '*';
                for (int i = 0; i < 10; i++)
                    Console.WriteLine("{0}", new string(a, i + 1));
            }
        }
    }
}
