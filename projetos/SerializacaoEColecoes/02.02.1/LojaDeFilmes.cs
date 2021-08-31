using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace _02._02._1
{
    public class LojaDeFilmes
    {
        private List<Diretor> diretores;
        public List<Diretor> Diretores
        {
            get { return diretores; }
            set
            {
                diretores = value;
            }
        }

        private List<Filme> filmes;
        public IReadOnlyCollection<Filme> Filmes
        {
            get { return new ReadOnlyCollection<Filme>(filmes); }
        }

        public LojaDeFilmes()
        {
            Inicializar();
        }

        public static void AdicionarFilme(Filme filme)
        {
            // Aqui vai a lógica de inserção de filme...
        }

        private void Inicializar()
        {
            Diretores = new List<Diretor>
                {
                    new Diretor("James Cameron",  5),
                    new Diretor("Francis Lawrence",  3),
                    new Diretor("Zack Snyder",  6),
                    new Diretor("Joss Whedon",  7),
                    new Diretor("Martin Scorsese",  4),
                    new Diretor("Christopher Nolan",  8),
                    new Diretor("Scott Derrickson",  4),
                    new Diretor("Gareth Edwards",  3),
                    new Diretor("Justin Kurzel",  6)
                };

            filmes = new List<Filme> {
                    new Filme (
                        new Diretor ( "James Cameron", 5 ),
                        "Avatar",
                        "2009"
                    ),
                    new Filme (
                        new Diretor ( "Francis Lawrence", 3 ),
                        "I Am Legend",
                        "2007"
                    ),
                    new Filme (
                        new Diretor ( "Zack Snyder", 6 ),
                        "300",
                        "2006"
                    ),
                    new Filme (
                        new Diretor ( "Joss Whedon", 7 ),
                        "The Avengers",
                        "2012"
                    ),
                    new Filme (
                        new Diretor ( "Martin Scorsese", 4 ),
                        "The Wolf of Wall Street",
                        "2013"
                    ),
                    new Filme (
                        new Diretor ( "Christopher Nolan", 8 ),
                        "Interstellar",
                        "2014"
                    ),
                    new Filme (
                        new Diretor ( "Jeremy Podeswa", 3 ),
                        "Game of Thrones",
                        "2011–"
                    ),
                    new Filme (
                        new Diretor ( "Michael Hirst", 4 ),
                        "Vikings",
                        "2013–"
                    ),
                    new Filme (
                        new Diretor ( "Danny Cannon", 1 ),
                        "Gotham",
                        "2014–"
                    ),
                    new Filme (
                        new Diretor ( "Courtney Kemp", 1 ),
                        "Power",
                        "2014–"
                    ),
                    new Filme (
                        new Diretor ( "Jose Padilha", 4 ),
                        "Narcos",
                        "2015–"
                    ),
                    new Filme (
                        new Diretor ( "Vince Gilligan", 2 ),
                        "Breaking Bad",
                        "2008–2013"
                    ),
                    new Filme (
                        new Diretor ( "Scott Derrickson", 4 ),
                        "Doctor Strange",
                        "2016"
                    ),
                    new Filme (
                        new Diretor ( "Gareth Edwards", 3 ),
                        "Rogue One: A Star Wars Story",
                        "2016"
                    ),
                    new Filme (
                        new Diretor ( "Justin Kurzel", 6 ),
                        "Assassin's Creed",
                        "2016"
                    ),
                    new Filme (
                        new Diretor ( "Charles Murray", 1 ),
                        "Luke Cage",
                        "2016–"
                    )
                };
        }
    }

    public class Diretor
    {
        public string Nome { get; set; }
        public int NumeroFilmes { get; set; }

        public Diretor(string nome, int numeroFilmes)
        {
            Nome = nome;
            NumeroFilmes = numeroFilmes;
        }
    }

    public class Filme
    {
        public Filme(Diretor diretor, string titulo, string ano)
        {
            Diretor = diretor;
            Titulo = titulo;
            Ano = ano;
        }

        public Diretor Diretor { get; }
        public string Titulo { get; }
        public string Ano { get; }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }
    }
}
