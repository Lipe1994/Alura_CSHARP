using System;
using System.Collections.Generic;
using System.Linq;

namespace consultar
{
    class Program
    {
        static void Main(string[] args)
        {

            var filmes = GetFilmes();
            var diretores = GetDiretores();

            //Projetando objeto dynamic na consulta, Poderia ser criado um tipo só para este propósito também
            var queryFilmes = filmes.Select(f => new
            {
                Titulo = f.Titulo,
                Nome = f.Diretor.Nome,
                Ano = f.Ano
            });

            Imprimir(queryFilmes.ToList());


            //Projetando usando Join
            Console.WriteLine("\r\n \r\n");
            Console.WriteLine("Projetando usando Join, onde diretor é o James C.");
            var queryFilmes2 = filmes.Join(diretores, x => x.DiretorId, y => y.Id, (x, y) => new {
                Titulo = x.Titulo,
                Nome = y.Nome,
                Ano = x.Ano
            }).Where(f => f.Nome.Contains("Tim "));

            Imprimir(queryFilmes2.ToList());



            //Prejetando usando orderby
            Console.WriteLine("\r\n \r\n");
            Console.WriteLine("Projetando usando OrderBy no nome, ordem decrescente");
            var queryFilmes3 = filmes.Join(diretores, x => x.DiretorId, y => y.Id, (x, y) => new {
                Titulo = x.Titulo,
                Nome = y.Nome,
                Ano = x.Ano
            }).OrderByDescending(f => f.Titulo);


            Imprimir(queryFilmes3.ToList());

            //Prejetando usando group by
            Console.WriteLine("\r\n \r\n");
            Console.WriteLine("Projetando usando group by");
            var queryFilmes4 = filmes.Join(diretores, x => x.DiretorId, y => y.Id, (x, y) => { x.Diretor = y; return x; }).GroupBy(f => f.Diretor).Select(f => new
            {
                MenorDuracao = f.Min(f => f.Minutos),
                MaiorDuracao = f.Max(f => f.Minutos),
                MediaDeDuracao = decimal.Round(((decimal)f.Average(f => f.Minutos)), 2),
                Minutos = f.Sum(f => f.Minutos),
                Diretor = f.First().Diretor.Nome,
                QTDFilmes = f.Count()
            });

            Imprimir2(queryFilmes4.ToList());

            Console.ReadKey();
        }

        private static void Imprimir(IEnumerable<dynamic> filmes)
        {
            Console.WriteLine($"{"Título",-40} {"Diretor",-20} {"Ano",4}");
            Console.WriteLine(new string('=', 64));
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Titulo,-40} {filme.Nome,-20} {filme.Ano,4}");
            }
        }

        private static void Imprimir2(IEnumerable<dynamic> filmes)
        {
            Console.WriteLine($"{"Diretor",-40} {"Tempo Total de filmes",20} {"Média", 10} {"Min", 5} {"Max", 5} {"QTDFilmes", 5}");
            Console.WriteLine(new string('=', 100));
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Diretor,-40} {filme.Minutos,20} {filme.MediaDeDuracao, 10} {filme.MenorDuracao, 5} {filme.MaiorDuracao, 5} {filme.QTDFilmes, 5}");
            }
        }

        private static List<Diretor> GetDiretores()
        {
            return new List<Diretor>
            {
                new Diretor { Id = 1, Nome = "Quentin Tarantino" },
                new Diretor { Id = 2, Nome = "James Cameron" },
                new Diretor { Id = 3, Nome = "Tim Burton" }
            };
        }

        private static List<Filme> GetFilmes()
        {
            return new List<Filme> {
                new Filme {
                    DiretorId = 1,
                    Diretor = new Diretor { Nome = "Quentin Tarantino" },
                    Titulo = "Pulp Fiction",
                    Ano = 1994,
                    Minutos = 2 * 60 + 34
                },
                new Filme {
                    DiretorId = 1,
                    Diretor = new Diretor { Nome = "Quentin Tarantino" },
                    Titulo = "Django Livre",
                    Ano = 2012,
                    Minutos = 2 * 60 + 45
                },
                new Filme {
                    DiretorId = 1,
                    Diretor = new Diretor { Nome = "Quentin Tarantino" },
                    Titulo = "Kill Bill Volume 1",
                    Ano = 2003,
                    Minutos = 1 * 60 + 51
                },

                new Filme {
                    DiretorId = 2,
                    Diretor = new Diretor { Nome = "James Cameron" },
                    Titulo = "Avatar",
                    Ano = 2009,
                    Minutos = 2 * 60 + 42
                },
                new Filme {
                    DiretorId = 2,
                    Diretor = new Diretor { Nome = "James Cameron" },
                    Titulo = "Titanic",
                    Ano = 1997,
                    Minutos = 3 * 60 + 14
                },
                new Filme {
                    DiretorId = 2,
                    Diretor = new Diretor { Nome = "James Cameron" },
                    Titulo = "O Exterminador do Futuro",
                    Ano = 1984,
                    Minutos = 1 * 60 + 47
                },

                new Filme {
                    DiretorId = 3,
                    Diretor = new Diretor { Nome = "Tim Burton" },
                    Titulo = "O Estranho Mundo de Jack",
                    Ano = 1993,
                    Minutos = 1 * 60 + 16
                },
                new Filme {
                    DiretorId = 3,
                    Diretor = new Diretor { Nome = "Tim Burton" },
                    Titulo = "Alice no País das Maravilhas",
                    Ano = 2010,
                    Minutos = 1 * 60 + 48
                },
                new Filme {
                    DiretorId = 3,
                    Diretor = new Diretor { Nome = "Tim Burton" },
                    Titulo = "A Noiva Cadáver",
                    Ano = 2005,
                    Minutos = 1 * 60 + 17
                }
            };
        }
    }

    class Diretor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    class Filme
    {
        public int DiretorId { get; set; }
        public Diretor Diretor { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public int Minutos { get; set; }
    }
}
