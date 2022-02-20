using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StateParallel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("processar 10 itens em paralelo");
            var itens = Enumerable.Range(0, 10);
            var result = Parallel.ForEach(itens, (i, state) => Processar(i));

            Console.WriteLine("Completou sem interrupção? {0}", result.IsCompleted);
            Console.WriteLine(new String('=', 100));


            Console.WriteLine("processar 10 itens em paralelo - cancelar o processamento por volta do indice 5");
            var result2 = Parallel.ForEach(itens, (int i, ParallelLoopState state)=> { 
                if(i == 5)
                {
                    state.Break();
                }
                Processar(i);
            });

            Console.WriteLine("Completou sem interrupção? {0}", result2.IsCompleted);
            Console.WriteLine("Quantos itens foram processados (parcialmente)? {0}", result2.LowestBreakIteration);

            Console.WriteLine("Término do processamento. Tecle [ENTER] para terminar.");
            Console.ReadLine();
        }

        static void Processar(object item)
        {
            Console.WriteLine("Começando a trabalhar com: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Terminando a trabalhar com: " + item);
        }
    }
}
