using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MUITAS TAREFAS EM PARALELO, COM PARÂMETRO
            //=========================================
            //Tarefa 1: processar 100 itens em série
            //Tarefa 2: processar 100 itens em paralelo - percorrendo uma faixa
            //Tarefa 3: processar 100 itens em paralelo - percorrendo uma coleção



            Console.WriteLine("processar 100 itens em série");
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 100; i++)
            {
                Processar(i);
            }
            watch.Stop();
            Console.WriteLine($"Tempo percorrido {watch.Elapsed}");
            Console.WriteLine(new String('=', 100) );

            Console.WriteLine("processar 100 itens em paralelo - percorrendo uma faixa");
            watch.Restart();
            watch.Start();
            Parallel.For(0, 100, (i)=> Processar(i));
            Console.WriteLine($"Tempo percorrido {watch.Elapsed}");
            Console.WriteLine(new String('=', 100));

            Console.WriteLine("processar 100 itens em paralelo - percorrendo uma coleção");
            watch.Restart();
            watch.Start();
            var itens = Enumerable.Range(0, 100);
            Parallel.ForEach(itens, (i, state) => Processar(i));
            Console.WriteLine($"Tempo percorrido {watch.Elapsed}");


        }

        static void Processar(object item)
        {
            Console.WriteLine("Começando a trabalhar com: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Terminando a trabalhar com: " + item);
        }
    }
}
