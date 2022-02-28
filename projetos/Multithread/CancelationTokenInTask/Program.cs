using System;
using System.Threading;
using System.Threading.Tasks;

namespace CancelationTokenInTask
{
    internal class Program
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Task task = Task.Run(() =>
            {
                ContagemRegressiva(cancellationTokenSource.Token);
            });
            Console.ReadKey();


            if (task.IsCompleted) 
            {
                Console.WriteLine("A contagem foi completada.");
            }
            else 
            {
                try 
                {
                    cancellationTokenSource.Cancel();
                    task.Wait();// esse await é para não perder a exception
                }catch (Exception ex) 
                {
                    Console.WriteLine("A contagem foi interrompida: {0}", ex?.InnerException.Message ?? ex.ToString());
                }
            }

            Console.ReadKey();
        }

        static void ContagemRegressiva(CancellationToken cancellationToken) 
        {
            int contador = 20;

            while (contador > 0) 
            {
                cancellationToken.ThrowIfCancellationRequested();//se alguém cancelar este token vai parar o rolê

                Console.WriteLine("contador: {0}", contador);
                Thread.Sleep(500);
                contador--;
            }
            cancellationToken.ThrowIfCancellationRequested();
        }
    }
}
