using System;

namespace _05._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            int hours = projectsCount * 3;
            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, hours, projectsCount);

        }
    }
}