using System;
using System.Collections.Generic;
using System.Diagnostics; 

namespace Obligave
{
    class ProgramOpgave2
    {
        private static Random random = new Random();
        private static Stopwatch stopwatch = new Stopwatch();

        public static void Run(int arrayLength, int stringLength)
        {
            TimeSpan ts;
            List<String> myList = GenerateRandomStrings(arrayLength, stringLength);

            // time bubble sort
            Console.WriteLine("Sorting with bubble sort");
            stopwatch.Start();
            List<String> sortedMyList = BubbleSort(myList);
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine(ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds + ":" + ts.Milliseconds);

            // time build in sort, possibly quicksort or insertion sort depending on the list size
            Console.WriteLine("Sorting with built-in sort");
            stopwatch.Reset();
            stopwatch.Start();
            myList.Sort();
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine(ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds + ":" + ts.Milliseconds);

            // time search

            String someValue = myList[random.Next(0, myList.Count + 1)];
            Console.WriteLine("Looking for " + someValue);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(myList.BinarySearch(someValue));
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            Console.WriteLine(ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds + ":" + ts.Milliseconds);
        }

        private static List<String> GenerateRandomStrings(int arrayLength, int stringLength)
        {
            

            List<String> strings = new List<String>();
            strings.Capacity = arrayLength;

            for (int i = 0; i < arrayLength; i++)
            {
                String temp = "";

                for(int j = 0; j < stringLength; j++)
                {
                    temp += ((char) random.Next(65, 91)).ToString();
                }

                strings.Add(temp);
            }
    
            return strings;
        }

        private static List<String> BubbleSort(List<String> list)
        {
            String temp;
            List<String> tempList = new List<string>(list);

            for (int p = 0; p <= tempList.Count - 2; p++)
            {
                for (int i = 0; i <= tempList.Count - 2; i++)
                {
                    if (string.Compare(tempList[i], tempList[i + 1]) > 0)
                    {
                        temp = tempList[i + 1];
                        tempList[i + 1] = tempList[i];
                        tempList[i] = temp;
                    }
                } 
            }

            return tempList;
        }
    }
}