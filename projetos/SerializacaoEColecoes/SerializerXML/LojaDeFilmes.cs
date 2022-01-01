using System.Collections.Generic;
using System.Xml.Serialization;

namespace moviestore
{
    [XmlRoot("MovieStore")]
    public class LojaDeFilmes //MovieStore
    {
        [XmlArray("Directors")]
        public List<Diretor> Diretores = new List<Diretor>(); //Directors
        [XmlArray("Movies")]
        public List<Filme> Filmes = new List<Filme>(); //Movies
        public static void AdicionarFilme(Filme filme)
        {
            // Aqui vai a lógica de inserção de filme...
        }
    }

    [XmlType("Director")]
    public class Diretor //Director
    {
        [XmlElement("Name")]
        public string Nome { get; set; } //Name
        [XmlIgnore]
        public int NumeroFilmes;//NumberOfMovies
    }

    [XmlType("Movie")]
    public class Filme //Movie
    {
        [XmlElement("Director")]
        public Diretor Diretor { get; set; } //Director
        [XmlElement("Title")]
        public string Titulo { get; set; } //Title
        [XmlElement("Year")]
        public string Ano { get; set; } //Year
    }
}
