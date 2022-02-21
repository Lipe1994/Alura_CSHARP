using System;
using System.Threading;
using System.Threading.Tasks;

namespace HierarquiaDeTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //A orquestração abaixo só funcionar se as Tasks forem iniciadas com padrão factory
            var task = Task.Factory.StartNew(()=> {
                Console.WriteLine("Mother Task Initializing.");

                for (int i = 0; i < 10; i++) 
                {
                    var index = i;
                    var taskChield = Task.Factory.StartNew(()=>ExecutarFilha(index), TaskCreationOptions.AttachedToParent); 
                }

                
            });

            task.Wait();
            Console.WriteLine("Mother Task done.");
        }

        private static void ExecutarFilha(object i)
        {
            Console.WriteLine("\tTarefa-filha {0} iniciou.", i);
            Thread.Sleep(1000);
            Console.WriteLine("\tTarefa-filha {0} terminou", i);
        }
    }
}
