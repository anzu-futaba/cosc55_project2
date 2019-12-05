using System;
using System.Diagnostics;
using System.Timers;

namespace DiscreteProject
{
    class main : Computation
    {
        // DISCRETE MATHEMATICS II PROJECT -- MADE BY: KEITH LAGUMBAY z BER //

        static void Main(string[] args)
        {
            loading anzu = new loading();
            var stopWatch = new Stopwatch();
            Process proc = new Process();
            stopWatch.Start();
            using (var timer = new Timer(1000))
            {
                timer.Elapsed += (sender, e) =>
                {
                    var elapsed = stopWatch.Elapsed;
                    Console.Title = String.Format("Discrete Mathematics II Project | Runtime: {0} second(s), {1} minute(s), {2} hour(s), {3} day(s)", elapsed.Seconds, elapsed.Minutes, elapsed.Hours, elapsed.Days);
                };
                timer.Start();
                anzu.load();
            }




        }

    }
}

