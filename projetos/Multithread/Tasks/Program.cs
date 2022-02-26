using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = new Task(()=> ExecutaTrabalho(1));
            task.Start();
            task.Wait();

            var task2 = Task.Run(() => ExecutaTrabalho(2) ); 
            task2.Wait();

            var task3 = Task.Run<int>(() => {
                var result = CalcularResultado(5, 2);
                return result;
            });
            Console.WriteLine($"resultado trabalho 3: {task3.Result}");

            Console.WriteLine("Término do processamento. Tecle [ENTER] para terminar.");
            Console.ReadLine();
        }

        public static void ExecutaTrabalho(int item)
        {
            Console.WriteLine("Trabalho iniciado: {0}", item);
            Thread.Sleep(2000);
            Console.WriteLine("Trabalho terminado: {0}", item);
            Console.WriteLine();
        }

        public static int CalcularResultado(int numero1, int numero2)
        {
            Console.WriteLine("Trabalho iniciado: 3");
            Thread.Sleep(2000);
            Console.WriteLine("Trabalho terminado: 3");
            return numero1 + numero2;
        }
    }
}
