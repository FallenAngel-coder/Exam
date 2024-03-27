using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
namespace Exam2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 100000000).ToArray();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double[] results = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                //results[i] = Math.Log(numbers[i]);
                Console.WriteLine("AAA");
                Console.Clear();
            }
            long first = stopwatch.ElapsedMilliseconds;
            stopwatch.Stop();
            stopwatch.Reset();
            stopwatch.Start();
            double[] parallelResults = new double[numbers.Length];
            Parallel.For(0, numbers.Length, i =>
            {
                //parallelResults[i] = Math.Log(numbers[i]);
                Console.WriteLine("AAA");
                Console.Clear();
            });
            stopwatch.Stop();
            Console.WriteLine($"Час виконання звичайного циклу: {first} мс");
            Console.WriteLine($"Час виконання з Parallel: {stopwatch.ElapsedMilliseconds} мс");
            bool resultsMatch = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (results[i] != parallelResults[i])
                {
                    resultsMatch = false;
                    break;
                }
            }
            if (resultsMatch)
                Console.WriteLine("Результати співпадають.");
            else
                Console.WriteLine("Результати не співпадають.");
            Console.ReadKey();
        }
    }
}
