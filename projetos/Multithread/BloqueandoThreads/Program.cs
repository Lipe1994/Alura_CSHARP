using System;
using System.Threading;

namespace BloqueandoThreads
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var contador = new Contador();

            Console.WriteLine("contador: {0}", contador.Numero);

            Thread thread1 = new Thread(()=>
            {
                for(int i = 0; i < 50; i++) 
                {
                    contador.Incrementar();
                    Thread.Sleep(i);
                }
            });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    contador.Incrementar();
                    Thread.Sleep(i);
                }
            });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("contador {0}", contador.Numero);
            Console.ReadLine();
        }
    }

    class Contador 
    {
        public int Numero { get; private set; } = 0;
        static object ContadorObject = new object();

        public void Incrementar() 
        {
            lock (ContadorObject) 
            {
                Numero++;
            }
        }
    }
}
