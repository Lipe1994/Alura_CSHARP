using System;
using System.Threading;

namespace ThreadInfo
{
    internal class Program
    {
        static void ExibirInformacoesDaThread(Thread t) 
        {
            Console.WriteLine();
            Console.WriteLine("Nome: {0}", t.Name);
            Console.WriteLine("Cultura: {0}", t.CurrentCulture);
            Console.WriteLine("Prioridade: {0}", t.Priority);
            Console.WriteLine("Contexto: {0}", t.ExecutionContext);
            Console.WriteLine("Está em background: {0}", t.IsBackground);
            Console.WriteLine("Está no ThreadPool: {0}", t.IsThreadPoolThread);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Thread principal";
            ExibirInformacoesDaThread(Thread.CurrentThread);

            var thread1 = new Thread(Executar);
            thread1.Name = "Thread1";
            thread1.Start();
            thread1.Join();

            var thread2 = new Thread(() => Executar());
            thread2.Name = "Thread2";
            thread2.Start();
            thread2.Join();

            var flagCompartilhada = true;
            var thread3 = new Thread(() =>
            {
                ExibirInformacoesDaThread(Thread.CurrentThread);
                while (flagCompartilhada) //Essa é uma técnica de compartilhamento de variáveis...
                {
                    Console.WriteLine("TIC");
                    Thread.Sleep(1000);
                    Console.WriteLine("TAC");
                    Thread.Sleep(1000);
                }
            });
            thread3.Name = "Thread3 - TIC TAC";
            thread3.Start();

            Console.WriteLine("Pressione [ENTER] para parar o relógio");
            Console.ReadKey();

            flagCompartilhada = false;
            thread3.Join();
            Console.WriteLine("flagCompartilhada: {0}", flagCompartilhada);

            Console.ReadKey();
            Console.WriteLine("OK");

        }



        static void Executar()
        {
            ExibirInformacoesDaThread(Thread.CurrentThread);
            Console.WriteLine("Início da execução");
            Thread.Sleep(1000);
            Console.WriteLine("Fim da execução");
        }

    }
}
