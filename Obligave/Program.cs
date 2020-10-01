using Obligave.Opgave3;
using System;

namespace Obligave
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            Console.WriteLine("## Opgave 1 ##");
            ProgramOpgave1.Run();
            Console.WriteLine();

            // Opgave 2
            Console.WriteLine("## Opgave 2 ##");
            ProgramOpgave2.Run(10000, 20); // 10k strings of length 20
            Console.WriteLine();


            // Opgave 3
            Console.WriteLine("## Opgave 3 ##");
            ProgramOpgave3.Run();
            Console.WriteLine();
        }
    }
}