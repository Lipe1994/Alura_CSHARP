using System;
using System.Collections.Generic;

namespace _02._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //COLEÇÃO: FILA = QUEUE
            //Regra: primeiro que entra é o primeiro que sai

            //TAREFA: Implementar uma fila de pedágio

            ///<image url="$(ProjectDir)\Slides\queue0.png" scale=""/>

            var pedagio = new Pedagio();
            pedagio.Enfileirar("van");
            pedagio.Enfileirar("kombi");
            pedagio.Enfileirar("guincho");
            pedagio.Enfileirar("pickup");

            pedagio.Desenfileirar();
            pedagio.Desenfileirar();
            pedagio.Desenfileirar();
            pedagio.Desenfileirar();
            pedagio.Desenfileirar();

            pedagio.Desenfileirar();
            pedagio.Desenfileirar();
        }
    }

    class Pedagio
    {
        Queue<string> fila = new Queue<string>();

        public void Enfileirar(string veiculo)
        {
            fila.Enqueue(veiculo);
            Console.WriteLine("Entrou na fila: " + veiculo);
            Imprimir();
        }

        private void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("VEÍCULOS NA FILA:");
            foreach (var v in fila)
            {
                Console.WriteLine(v);
            }
        }

        public void Desenfileirar()
        {
            if (fila.Count == 0)
            {
                Console.WriteLine("A fila já está vazia!");
                return;
            }

            var proximo = fila.Peek();
            Console.WriteLine("O próximo da fila é: " + proximo);

            var veiculo = fila.Dequeue();
            Console.WriteLine("Saiu da fila: " + veiculo);
            Imprimir();

            fila.TryPeek(out proximo);
            Console.WriteLine("O próximo da fila é: " + proximo);

        }
    }
}
