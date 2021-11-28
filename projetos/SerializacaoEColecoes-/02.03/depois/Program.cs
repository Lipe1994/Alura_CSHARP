using System;
using System.Collections.Generic;

namespace _02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //DICIONÁRIO

            //declarando dicionário de filmes
            Dictionary<int, Filme> filmes = new Dictionary<int, Filme>();

            //adicionando: 34672-esperanca, 5617-imperio, 17645-retorno
            filmes.Add(34672, esperanca);
            filmes.Add(5617, imperio);
            filmes.Add(17645, retorno);

            //Imprimindo os filmes cadastrados
            foreach (var filme in filmes)
            {
                Console.WriteLine(filme);
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine(filme.Key);
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine(filme.Value);
            }

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            //Um dicionário permite associar uma chave (ID do filme) a um valor (o filme)

            //Qual é o filme com ID 34672?
            Console.WriteLine("Qual é o filme com ID 34672? " + filmes[34672]);

            //e se tentarmos adicionar outro filme com mesma chave 34672?
            //filmes.Add(34672, ameaca);

            //e se quisermos trocar o filme que tem a mesma chave?
            filmes[34672] = ameaca;

            //pergunta: "Quem é o Filme 34672 agora?"
            Console.WriteLine("Quem é o Filme 34672 agora? " + filmes[34672]);

            //buscando uma chave que não existe: 34673
            //Console.WriteLine("buscando uma chave que não existe: 34673" + filmes[34673]);

            //verificando se a chave 34673 existe
            Console.WriteLine("verificando se a chave 34673 existe " + filmes.ContainsKey(34673));

            //buscando uma chave 34673 de forma segura
            filmes.TryGetValue(34673, out Filme filme34673);

            if (filme34673 == null)
            {
                Console.WriteLine("Filme com chave 34673 não existe.");
            }

            //Como um dicionário armazena os valores (diagrama)
            ///<image url="$(ProjectDir)\image.png" scale=""/>
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

        public override bool Equals(object obj)
        {
            Filme outra = obj as Filme;
            if (outra == null)
            {
                return false;
            }

            return outra.Titulo.Equals(this.Titulo)
                && outra.Ano.Equals(this.Ano);
        }

        public override int GetHashCode()
        {
            var hashCode = -131496797;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titulo);
            hashCode = hashCode * -1521134295 + Ano.GetHashCode();
            return hashCode;
        }
    }
}
