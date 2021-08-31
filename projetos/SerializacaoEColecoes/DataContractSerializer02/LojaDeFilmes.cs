using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace datacontract.serialize
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
    public class Diretor : ISerializable
    {
        public string Nome { get; set; }
        public int NumeroFilmes;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Nome), Nome);
            info.AddValue(nameof(NumeroFilmes), NumeroFilmes);
            info.AddValue("Resumo", $"Nome: {Nome}, Número de Filmes: {NumeroFilmes}");
        }
    }

    [Serializable]
    public class Filme
    {
        public Diretor Diretor { get; set; }
        public string Titulo { get; set; }
        public string Ano { get; set; }
    }
}
