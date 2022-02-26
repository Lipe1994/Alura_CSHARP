using System;
using System.Threading;

namespace _ThreadPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++) 
            {
                int indexCurrenteScope = i;

                ThreadPool.QueueUserWorkItem((_)=> ExecutarComParametro(indexCurrenteScope));

            }
            Console.ReadKey();
        }

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

        static void ExecutarComParametro(object param)
        {
            Thread.CurrentThread.Name = param.ToString();
            Console.WriteLine("Início da execução: {0}", param);
            ExibirInformacoesDaThread(Thread.CurrentThread);
            Thread.Sleep(1000);
            Console.WriteLine("Fim da execução: {0}", param);
        }
    }
}