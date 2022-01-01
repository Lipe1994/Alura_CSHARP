using System;
using System.Collections.Generic;

namespace conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //Conjuntos => set
            ISet<Filme> conjuntoDeFilmes = new HashSet<Filme>();

            //Adicionando
            conjuntoDeFilmes.Add(ameaca);
            conjuntoDeFilmes.Add(ameaca);//Note que Ameaça não será adicionado 2 vezes porque se trata de um conjunto
            conjuntoDeFilmes.Add(retorno);
            conjuntoDeFilmes.Add(imperio);
            conjuntoDeFilmes.Add(esperanca);

            Imprimir(conjuntoDeFilmes);

            //Testando o Contains
            Console.WriteLine("Conjunto contém  'Episódio IV -Uma nova esperança'? " + conjuntoDeFilmes.Contains(esperanca));

            //Testando novamente com valores iguais porém em instancias diferentes, Caso não contenha o override de Equals e HashCode
            //na classe que representa um item do conjunto, será comparado levando em consideração se é a mesma instancia
            var esperanca2 = new Filme("episódio iv -uma nova esperança", 1977);//nos overrides me certifiquei de ignorar o case...
            Console.WriteLine("Conjunto contém  'Episódio IV -Uma nova esperança'? " + conjuntoDeFilmes.Contains(esperanca2));

            //transformando o hashset em um list para poder ordena-lo
            var listaDeFilmes = new List<Filme>(conjuntoDeFilmes);
            Imprimir(listaDeFilmes);
            listaDeFilmes.Sort();
            Imprimir(listaDeFilmes);
        }

        static void Imprimir<T>(IEnumerable<T> enumerable) 
        {
            Console.WriteLine($"\r\n{string.Join(",\r\n", enumerable)}\r\n");
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

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }

        public override bool Equals(object obj)
        {
            var filme = obj as Filme;
            if (filme == null) 
            {
                return false;
            }

            return filme.Titulo.ToUpper().Equals(this.Titulo.ToUpper()) && filme.Ano.Equals(this.Ano);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Titulo.ToUpper(), Ano);
        }

        public int CompareTo(object obj)
        {
            var filme = obj as Filme;
            if (filme == null)
            {
                return 1;
            }

            if (this.Ano.CompareTo(filme.Ano) == 0) 
            {
                return filme.Titulo.CompareTo(this.Titulo);
            }

            return this.Ano.CompareTo(filme.Ano);
        }
    }
}
