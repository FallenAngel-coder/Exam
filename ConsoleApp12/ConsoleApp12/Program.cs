using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskEx1();
            TaskEx2();
            Console.WriteLine("Продовження коду");
            Console.ReadKey();
            Console.WriteLine("-----------------------------------");
            NoTask1();
            NoTask2();
            Console.ReadKey();
        }
        public static async Task TaskEx1()
        {
            Task task1 = Task.Run(() =>
            {
                Console.WriteLine("Початок виконання завдання 1...");
                Task.Delay(4000).Wait(); 
                Console.WriteLine("Завершення виконання завдання 1.");
            });
            await task1; 
        }
        public static async Task TaskEx2()
        {
            Task task2 = Task.Run(() =>
            {
                Console.WriteLine("Початок виконання завдання 2...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Завершення виконання завдання 2.");
            });
            await task2.ContinueWith((t) =>
            {
                Console.WriteLine("Код після виконання завдання 2.");
            });
        }
        public static void NoTask1()
        {
            Console.WriteLine("Початок виконання завдання 1...");
            Thread.Sleep(4000);
            Console.WriteLine("Завершення виконання завдання 1.");
        }        
        public static void NoTask2()
        {
            Console.WriteLine("Початок виконання завдання 2...");
            Thread.Sleep(3000);
            Console.WriteLine("Завершення виконання завдання 2.");
        }
    }
}
