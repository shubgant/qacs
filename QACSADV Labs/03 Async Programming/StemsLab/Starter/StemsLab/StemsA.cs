using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;


namespace StemsLab
{
    public class StemsA
    {
        private static Tuple<int, string, int> StemSearch(Dictionary <string, int> stems, int stemSize)
        {
            Tuple<int, string, int> val = null;
                        
            string bestStem = "";
            int bestCount = 0;

            foreach (KeyValuePair<string, int> entry in stems)
            {
                string stem = entry.Key;
                int count = entry.Value;

                if (stemSize == stem.Length && count > bestCount)
                {
                    bestStem = stem;
                    bestCount = count;
                }
            }

            if (!string.IsNullOrEmpty(bestStem))
            {
                //Console.WriteLine("Most popular stem of size " + stemSize + " is: " + bestStem + " (occurs " + bestCount + " times)");
                val = new Tuple<int, string, int>(stemSize, bestStem, bestCount);
            }

            return val;

        }

        public static void FindStems(Dictionary<string, int> stems)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Reset();
            stopwatch.Start();

            int n = 30;
            List<Task<Tuple<int, string, int>>> tasks = [];
            List<Tuple<int, string, int>> popularStems = [];

            for (int stemSize = 2; stemSize <= n + 1; stemSize++)
            {
                int size = stemSize;
                Task<Tuple<int, string, int>> task = Task.Run(() => StemSearch(stems, size));
                tasks.Add(task);
            }

            Task.WhenAll(tasks).Wait();

            tasks.ForEach(t =>
            {
                popularStems.Add(t.Result);
            });

            popularStems.ForEach(r =>
            {
                if (r is not null)
                {
                    Console.WriteLine("Most popular stem of size " + r.Item1 + " is: " + r.Item2 + " (occurs " + r.Item3 + " times)");
                }
            });

            stopwatch.Stop();
            Console.WriteLine("Process: " + stopwatch.Elapsed);
        }
    }
}
