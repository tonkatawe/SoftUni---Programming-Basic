using System;

namespace _02._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumeSwimingPool = int.Parse(Console.ReadLine());
            int flowPipe1 = int.Parse(Console.ReadLine());
            int flowPipe2 = int.Parse(Console.ReadLine());
            double lessofHours = double.Parse(Console.ReadLine());
            double pipeHours1 = flowPipe1 * lessofHours;
            double pipeHours2 = flowPipe2 * lessofHours;
            double pipeTogether = pipeHours1 + pipeHours2;
            if (pipeTogether <= volumeSwimingPool)
            {
                double volumeInPercent = (pipeTogether / volumeSwimingPool) * 100;
                double volumePipe1Percent = (pipeHours1 / pipeTogether) * 100;
                double volumePipe2Percent = (pipeHours2 / pipeTogether) * 100;
                Console.WriteLine($"The pool is {Math.Truncate(volumeInPercent)}% full. Pipe 1: {Math.Truncate(volumePipe1Percent)}%. Pipe 2: {Math.Truncate(volumePipe2Percent)}%.");
            }
            else if (pipeTogether > volumeSwimingPool)
            {

                Console.WriteLine($"For {lessofHours} hours the pool overflows with {pipeTogether - volumeSwimingPool} liters.");
            }



        }
    }
}


