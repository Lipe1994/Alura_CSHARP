using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlText =
            "<Filmes>" +
                "<Filme>" +
                    "<Diretor>Quentin Tarantino</Diretor>" +
                    "<Titulo>Pulp Fiction</Titulo>" +
                    "<Minutos>154</Minutos>" +
                "</Filme>" +
                "<Filme>" +
                    "<Diretor>James Cameron</Diretor>" +
                    "<Titulo>Avatar</Titulo>" +
                    "<Minutos>162</Minutos>" +
                "</Filme>" +
            "</Filmes>";

            var xmlDoc = XDocument.Parse(xmlText);

            var filmes = xmlDoc.Root;

            foreach(var filme in filmes.Elements()) 
            {
                Console.WriteLine(filme.Element("Diretor").Value);
            }

            Console.WriteLine("\r\n\r\n");
            Console.WriteLine("Usando sintaxe de consulta, Filme quando diretor for 'James Cameron': ");
            //Usando sintaxe de consulta
            var query1 = from f in filmes.Elements()
                         where (string)f.Element("Diretor") == "James Cameron"
                         select f;

            foreach (var f in query1)
            {
                Console.WriteLine(f.Element("Titulo").Value);
            }

            Console.WriteLine("\r\n\r\n");
            Console.WriteLine("Usando sintaxe de função, Filme quando diretor for 'Quentin Tarantino': ");
            //Usando sintaxe de consulta
            var query2 = filmes.Elements().Where(f => f.Element("Diretor").Value.Equals("Quentin Tarantino")).Single();


            Console.WriteLine(query2.Element("Titulo").Value);


            Console.WriteLine("\r\n\r\n");
            Console.WriteLine("Adicionando um node no doc de consulta");
            var query3 = (from f in filmes.Elements()
                         where (string)f.Element("Diretor") == "James Cameron"
                         select f).Single();

            query3.Add(new XElement("Titulo", "Teste"));

            foreach (var f in query3.Descendants())
            {
                Console.WriteLine(f.Value);
            }

        }
    }
}
