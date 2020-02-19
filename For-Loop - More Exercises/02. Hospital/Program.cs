using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int countDays = 0;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;
            for (int i = 0; i < period; i++)
            {
                countDays++;
                if (countDays == 3)
                {
                    countDays = 0;
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients <= doctors)
                {

                    treatedPatients += patients;
                }
                else
                {
                    untreatedPatients += patients - doctors;
                    treatedPatients += doctors;
                }


            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
