using System;
using System.Threading.Tasks;

namespace OrquestrandoTarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task tarefa = Task.Run(()=> Ola());

            tarefa.ContinueWith((_) => Mundo(), TaskContinuationOptions.NotOnFaulted);

            tarefa.ContinueWith((tarefaAnterior) => Erro(tarefaAnterior), TaskContinuationOptions.OnlyOnFaulted);

            Console.ReadLine();
        }

        private static void Mundo()
        {
            Console.WriteLine("Mundo");
        }

        private static void Ola()
        {
            Console.WriteLine("Olá");
            throw new ApplicationException("Opa! Ocorreu erro no método Olá");
        }

        private static void Erro(Task tarefaAnterior)
        {
            var excecoes = tarefaAnterior.Exception.InnerExceptions;

            foreach (var excecao in excecoes)
            {
                Console.WriteLine(excecao);
            }
        }
    }
}
