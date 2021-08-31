using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;



namespace jsonserializer
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) System.Text.Json
            Console.WriteLine("----------------- System.Text.Json ----------------");

            LojaDeFilmes loja = ObterDados();

            // var json = System.Text.Json.JsonSerializer.Serialize<LojaDeFilmes>(loja as LojaDeFilmes);

            // Console.WriteLine(json);

            // using (var streamWriter = new StreamWriter("Loja-system-text.json"))
            // {
            //     streamWriter.Write(json);
            // }

            // using(var fileStream = new FileStream("Loja-system-text.json", FileMode.Open, FileAccess.Read))
            // {
            //     using(var streamReader = new StreamReader(fileStream))
            //     {
            //         var copiaDaLoja = System.Text.Json.JsonSerializer.Deserialize<LojaDeFilmes>(streamReader.ReadToEnd());
            //         foreach (var filme in copiaDaLoja.Filmes)
            //         {
            //             Console.WriteLine(filme.Titulo);
            //         }
            //     }
            // }

            //2) NewtonSoft.JSON
            Console.WriteLine("----------------- NewtonSoft.JSON ----------------");
            var json = JsonConvert.SerializeObject(loja);
            Console.WriteLine(json);

            using (var streamWriter = new StreamWriter("Loja-newton-soft.json"))
            {
                streamWriter.Write(json);
            }

            //copiaDaLoja = (LojaDeFilmes)JsonConvert.DeserializeObject(json);

            using(var fileStream = new FileStream("Loja-newton-soft.json", FileMode.Open, FileAccess.Read))
            {
                using(var streamReader = new StreamReader(fileStream))
                {

                    // var copiaDaLoja = JsonConvert.DeserializeObject<LojaDeFilmes>(streamReader.ReadToEnd());
                    // foreach (var filme in copiaDaLoja.Filmes)
                    // {
                    //     Console.WriteLine(filme.Titulo);
                    // }

                    MovieStore movieStore = JsonConvert.DeserializeObject<MovieStore>(streamReader.ReadToEnd());
                    foreach (var movie in movieStore.Movies)
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
            }

            Console.ReadKey();
        }

        private static LojaDeFilmes ObterDados()
        {
            return new LojaDeFilmes
            {
                Diretores = new List<Diretor>
                {
                    new Diretor { Nome = "James Cameron", NumeroFilmes = 5 },
                    new Diretor { Nome = "Francis Lawrence", NumeroFilmes = 3 },
                    new Diretor { Nome = "Zack Snyder", NumeroFilmes = 6 },
                    new Diretor { Nome = "Joss Whedon", NumeroFilmes = 7 },
                    new Diretor { Nome = "Martin Scorsese", NumeroFilmes = 4 },
                    new Diretor { Nome = "Christopher Nolan", NumeroFilmes = 8 },
                    new Diretor { Nome = "Scott Derrickson", NumeroFilmes = 4 },
                    new Diretor { Nome = "Gareth Edwards", NumeroFilmes = 3 },
                    new Diretor { Nome = "Justin Kurzel", NumeroFilmes = 6 }
                },
                Filmes = new List<Filme> {
                    new Filme {
                        Diretor = new Diretor { Nome = "James Cameron", NumeroFilmes = 5 },
                        Titulo = "Avatar",
                        Ano = "2009"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Francis Lawrence", NumeroFilmes = 3 },
                        Titulo = "I Am Legend",
                        Ano = "2007"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Zack Snyder", NumeroFilmes = 6 },
                        Titulo = "300",
                        Ano = "2006"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Joss Whedon", NumeroFilmes = 7 },
                        Titulo = "The Avengers",
                        Ano = "2012"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Martin Scorsese", NumeroFilmes = 4 },
                        Titulo = "The Wolf of Wall Street",
                        Ano = "2013"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Christopher Nolan", NumeroFilmes = 8 },
                        Titulo = "Interstellar",
                        Ano = "2014"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Game of Thrones",
                        Ano = "2011–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Vikings",
                        Ano = "2013–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Gotham",
                        Ano = "2014–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Power",
                        Ano = "2014–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Narcos",
                        Ano = "2015–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Breaking Bad",
                        Ano = "2008–2013"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Scott Derrickson", NumeroFilmes = 4 },
                        Titulo = "Doctor Strange",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Gareth Edwards", NumeroFilmes = 3 },
                        Titulo = "Rogue One: A Star Wars Story",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Justin Kurzel", NumeroFilmes = 6 },
                        Titulo = "Assassin's Creed",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Luke Cage",
                        Ano = "2016–"
                    }
                }
            };
        }
    }
}
