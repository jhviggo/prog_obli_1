using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Obligave.Opgave3
{
    class ProgramOpgave3
    {
        private static Stopwatch stopwatch = new Stopwatch();

        public static void Run()
        {
            try
            {
                generateUnsavedHenries();

                // FOR THE LOVE OF GOD DO NOT RUN
                generateSavedHenries();
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void generateUnsavedHenries()
        {
            Console.WriteLine("Generating Henries...");
            stopwatch.Start();
            for (int i = 0; i < 1000000000; i++) 
            {
                Henry henry = new Henry();
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.Write("Henries generated in ");
            Console.WriteLine(ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds + ":" + ts.Milliseconds);
        }

        private static void generateSavedHenries()
        {
            List<Henry> henries = new List<Henry>();
            Console.WriteLine("Generating Henries...");
            stopwatch.Start();
            for (int i = 0; i < 1000000000; i++) 
            {
                henries.Add(new Henry());
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.Write("Henries generated in ");
            Console.WriteLine(ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds + ":" + ts.Milliseconds);
        }
    }
}
