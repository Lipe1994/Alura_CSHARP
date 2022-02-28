using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BloqueandoTasks
{
    internal class Program
    {
        static long somaGeral;
        static object somaGeralObject = new object();
        static int[] itens = Enumerable.Range(0, 100_001).ToArray();
        static void Main(string[] args)
        {
            while (true) 
            {
                Executar();
                Thread.Sleep(1000);
            }
        }

        static void AdicionarFaixaDeValores(int inicio, int fim) 
        {
            long subTotal = 0;

            while (inicio < fim) 
            {
                subTotal = subTotal + itens[inicio];

                inicio++;
            }

            //somaGeral = somaGeral + subTotal;

            //Lock garante que quando uma Thread chegar nesta linha, as concorrentes aguardaram pelo desbloqueio
            //lock (somaGeralObject) 
            //{
            //    somaGeral = somaGeral + subTotal;
            //}

            //Mais uma forma de usar lock (Monitor possui metodo mostra se Thread foi bloqueada Monitor.TryEnter)
            Monitor.Enter(somaGeralObject);
            //Usando try, é possível garantir que se houver exceções o Monitor irá desbloquear a Execução para próximas Threads
            try
            {
                somaGeral = somaGeral + subTotal;
            }
            finally
            {
                Monitor.Exit(somaGeralObject);
            }
        }

        static void Executar() 
        {
            //Console.WriteLine("itens.Length {0}", itens.Length);
            //Console.WriteLine("itens.LastOrDefault() {0}", itens.LastOrDefault());
            somaGeral = 0;
            List<Task> tarefas = new List<Task>();
            int tamanhoFaixa = 1000;
            int inicioFaixa = 0;

            while (inicioFaixa < itens.Length)
            {
                int fimFaixa = inicioFaixa + tamanhoFaixa;
                if(fimFaixa > itens.Length) 
                {
                    fimFaixa = itens.Length;
                }

                int i = inicioFaixa;
                int f = fimFaixa;
                tarefas.Add(Task.Run(()=> AdicionarFaixaDeValores(i, f)));
                inicioFaixa = fimFaixa;

            }
            Task.WaitAll(tarefas.ToArray());
            Console.WriteLine("A soma geral é: {0}", somaGeral);
        }
    }
}
