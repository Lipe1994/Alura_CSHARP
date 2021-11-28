using Newtonsoft.Json;
using System.Collections.Generic;

namespace jsonserializer
{
    [JsonObject("MovieStore")]
    public class LojaDeFilmes
    {
        [JsonProperty("Directors")]
        public List<Diretor> Diretores = new List<Diretor>();
        [JsonProperty("Movies")]
        public List<Filme> Filmes = new List<Filme>();
        public static void AdicionarFilme(Filme filme)
        {
            // Aqui vai a lógica de inserção de filme...
        }
    }

    [JsonObject("Director")]
    public class Diretor
    {
        [JsonProperty("Name")]
        public string Nome { get; set; }
        [JsonIgnore]
        public int NumeroFilmes;
    }

    [JsonObject("Movie")]
    public class Filme
    {
        [JsonProperty("Director")]
        public Diretor Diretor { get; set; }
        [JsonProperty("Title")]
        public string Titulo { get; set; }
        [JsonProperty("Year")]
        public string Ano { get; set; }
    }
}
