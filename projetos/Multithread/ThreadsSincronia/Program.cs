using System;
using System.Threading;

namespace ThreadsSincronia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(Executar);
            thread1.Start();
            thread1.Join();

            var thread2 = new Thread(() => Executar());
            thread2.Start();
            thread2.Join();

            var flagCompartilhada = true;
            var thread3 = new Thread(()=>
            {
                while (flagCompartilhada) //Essa é uma técnica de compartilhamento de variáveis...
                {
                    Console.WriteLine("TIC");
                    Thread.Sleep(1000);
                    Console.WriteLine("TAC");
                    Thread.Sleep(1000);
                }
            });
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
