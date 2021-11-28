using System;
using System.Collections.Generic;

namespace _02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //SETS = CONJUNTOS

            //declarando set de filmes

            //adicionando: esperanca, imperio, retorno

            //Características do Set (conjunto)
            //1. não permite duplicidade

            //2. os elementos não são mantidos em ordem específica

            //3. não permite acesso pelo índice

            //qual a vantagem do set sobre a lista? tempo de pesquisa!
            //https ://stackoverflow.com/a/10762995

            //desvantagem: consumo de memória

            //É possível ordenar um conjunto?

            //copiando para uma lista

            //ordenando copia

            //imprimindo copia

            //verificando se objeto existe

            //verificando se objeto com mesmos dados existe
        }

        private static void Imprimir(IEnumerable<Filme> filmes)
        {
            foreach (var filme in filmes)
            {
                Console.WriteLine(filme);
            }
            Console.WriteLine();
        }
    }

    public class Filme : IComparable
    {
        public Filme(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        public int CompareTo(object obj)
        {
            Filme esta = this;
            Filme outra = obj as Filme;

            if (outra == null)
            {
                return 1;
            }

            return esta.Titulo.CompareTo(outra.Titulo);
        }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }
    }
}
