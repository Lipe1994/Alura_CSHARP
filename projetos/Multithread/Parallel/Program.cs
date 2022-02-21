using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizando tarefas com processamento syncrono: ");
            var watch = new Stopwatch();
            watch.Start();
            CozinharMacarrao();
            RefogarMolho();
            watch.Stop();
            Console.WriteLine($"Tempo em processamento syncrono {watch.Elapsed}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Realizando tarefas com processamento Asyncrono: ");
            watch.Restart();
            watch.Start();
            Parallel.Invoke(CozinharMacarrao, RefogarMolho);
            watch.Stop();
            Console.WriteLine($"Tempo em processamento Asyncrono {watch.Elapsed}");
            Console.WriteLine();


        }

        static void CozinharMacarrao()
        {
            Console.WriteLine("Cozinhando macarrão...");
            Thread.Sleep(1000);
            Console.WriteLine("Macarrão já está cozido!");
            Console.WriteLine();
        }

        static void RefogarMolho()
        {
            Console.WriteLine("Refogando molho...");
            Thread.Sleep(2000);
            Console.WriteLine("Molho já está refogado!");
            Console.WriteLine();
        }
    }
}
