using System;

namespace _01._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursArrive = int.Parse(Console.ReadLine());
            int minutesArrive = int.Parse(Console.ReadLine());
            int totalMinutesExam = hoursExam * 60 + minutesExam;
            int totalMinutesArrive = hoursArrive * 60 + minutesArrive;
            int hours = 0;
            int minutes = 0;
            int rest = 0;
            if (totalMinutesArrive > totalMinutesExam)
            {
                Console.WriteLine("Late");
                if ((totalMinutesArrive - totalMinutesExam) <= 59)
                {
                    rest = totalMinutesArrive - totalMinutesExam;
                    hours = rest / 60;
                    minutes = rest % 60;
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                if ((totalMinutesArrive - totalMinutesExam) > 59)
                {
                    rest = totalMinutesArrive - totalMinutesExam;
                    hours = (totalMinutesArrive - totalMinutesExam) / 60;
                    minutes = (totalMinutesArrive - totalMinutesExam) % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
            }
            if ((totalMinutesArrive - totalMinutesExam) == 0)
            {
                Console.WriteLine("On time");

            }
            else if ((totalMinutesArrive - totalMinutesExam) <= 30)
            {
                rest = Math.Abs(totalMinutesArrive - totalMinutesExam);
                hours = rest / 60;
                minutes = rest % 60;
                Console.WriteLine("On time");
                Console.WriteLine($"{minutes} minutes before the start");
            }
            if ((totalMinutesExam - totalMinutesArrive) > 30)
            {
                rest = (totalMinutesExam - totalMinutesArrive);
                Console.WriteLine("Early");
                if (rest <= 59)
                {
                    minutes = rest;
                    Console.WriteLine($"{minutes} minutes before  the start");
                }
                else if (rest > 59)
                {

                    hours = (totalMinutesExam - totalMinutesArrive) / 60;
                    minutes = (totalMinutesExam - totalMinutesArrive) % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }

            }
        }
    }
}