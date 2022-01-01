using System;
using System.Collections.Generic;

namespace Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //Fila = Qeue
            var filmes = new Filmes();

            //Enfileirando
            filmes.Enfileirar(esperanca);
            filmes.Enfileirar(imperio);
            filmes.Enfileirar(retorno);
            filmes.Enfileirar(ameaca);

            //desenfileirando
            filmes.Desenfileirar();


        }
    }
    public class Filme
    {
        public Filme(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }

    }

    class Filmes 
    {
        public Filmes() 
        {
            this.filaDefilmes = new Queue<Filme>(); 
        }
        public Queue<Filme> filaDefilmes { get; set; }

        void Imprimir<T>(IEnumerable<T> enumerable)
        {
            Console.WriteLine($"\r\n{string.Join(",\r\n", enumerable)}\r\n");
        }

        private void ShowFila()
        {
            Imprimir(filaDefilmes);
        }

        public void Enfileirar(Filme filme)
        {
            filaDefilmes.Enqueue(filme);
            Console.WriteLine($"O filme '{filme.Titulo}' entrou na fila");
            ShowFila();
        }

        public void Desenfileirar()
        {
            var filme = filaDefilmes.Peek();
            filaDefilmes.Dequeue();
            Console.WriteLine($"O filme '{filme.Titulo}' saiu da fila");
            filme = null;
            ShowFila();
        }

    }
}
