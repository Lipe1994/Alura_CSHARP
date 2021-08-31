using System;
using System.Collections.Generic;

namespace serializer.binario
{
    [Serializable]
    public class LojaDeFilmes
    {
        public List<Diretor> Diretores = new List<Diretor>();
        public List<Filme> Filmes = new List<Filme>();
        public static void AdicionarFilme(Filme filme)
        {
            // Aqui vai a lógica de inserção de filme...
        }
    }

    [Serializable]
    public class Diretor
    {
        public string Nome { get; set; }
        [NonSerialized]
        public int NumeroFilmes;
    }

    [Serializable]
    public class Filme
    {
        public Diretor Diretor { get; set; }
        public string Titulo { get; set; }
        public string Ano { get; set; }
    }
}
