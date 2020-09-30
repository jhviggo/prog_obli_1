using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Obligave.Opgave3
{
    class ProgramOpgave3
    {
        private static Stopwatch stopwatch = new Stopwatch();

        public static void Run()
        {
            Console.WriteLine("Generating Henry...");
            stopwatch.Start();
            for (int i = 0; i < 10000000000; i++) 
            {
                Henry henry = new Henry();
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Henry generated");
            Console.WriteLine(ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds + ":" + ts.Milliseconds);

        }
    }
}
