using System;
using System.Collections.Generic;

namespace _02._02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var loja = new LojaDeFilmes();

            foreach (var filme in loja.Filmes)
            {
                Console.WriteLine(filme);
            }

            Console.WriteLine();

            //loja.Filmes[0].Titulo = "EVITAR";

            foreach (var filme in loja.Filmes)
            {
                Console.WriteLine(filme);
            }

            //loja.Filmes = new List<Filme>();

            //loja.Filmes.RemoveAt(0);
            //loja.Filmes.Add(new Filme(new Diretor("Zé Ninguém", 3), "Um Filme Qualquer", "2018"));
            //loja.Filmes.Clear();
            Console.WriteLine();
            foreach (var filme in loja.Filmes)
            {
                Console.WriteLine(filme);
            }
        }
    }
}
