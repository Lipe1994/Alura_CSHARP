using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace EsperaContinuacaoEHierarquia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de threads: {0}", Process.GetCurrentProcess().Threads.Count);

            Task[] tasks = new Task[10];

            for (int i = 0; i < tasks.Length; i++) 
            {
                var currentIndex = i;
                var tread = Task.Run(()=> Correr(currentIndex));
                tasks[i] = tread;
            }

            Task.WaitAll(tasks);
            Console.WriteLine("Número de threads: {0}", Process.GetCurrentProcess().Threads.Count);
        }

        public static void Correr(int numeroCorredor)
        {
            Console.WriteLine("Corredor {0} largou", numeroCorredor);

            Thread.Sleep(1000);
            Console.WriteLine("Corredor {0} terminou", numeroCorredor);
        }

    }
}
