using System;
using System.Threading;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(Executar);
            thread1.Start();

            var thread2 = new Thread(()=> Executar());
            thread2.Start();


            var thread3 = new Thread(ExecutarComParametro);
            thread3.Start(123);

            ParameterizedThreadStart param = new ParameterizedThreadStart((p)=> ExecutarComParametro(p));
            var thread4 = new Thread(param);
            thread4.Start(456);
        }



        static void Executar()
        {
            Console.WriteLine("Início da execução");
            Thread.Sleep(1000);
            Console.WriteLine("Fim da execução");
        }


        static void ExecutarComParametro(object param)
        {
            Console.WriteLine("Início da execução: {0}", param);
            Thread.Sleep(1000);
            Console.WriteLine("Fim da execução: {0}", param);
        }
    }
}
