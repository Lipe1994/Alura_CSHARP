using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsultasParalelas
{
    public class Filme
    {
        public Filme() { }
        public Filme(Filme f) 
        {
            Titulo = f.Titulo;
            Faturamento = f.Faturamento;
            Orcamento = f.Orcamento;
            Distribuidor = f.Distribuidor;
            Genero = f.Genero;
            Diretor = f.Diretor;
            Lucro = f.Faturamento - f.Orcamento;
            LucroPorcentagem = (f.Faturamento - f.Orcamento) / f.Orcamento;
        }

        public string Titulo { get; set; }
        public decimal Faturamento { get; set; }
        public decimal Orcamento { get; set; }
        public string Distribuidor { get; set; }
        public string Genero { get; set; }
        public string Diretor { get; set; }
        public decimal Lucro { get; set; }
        public decimal LucroPorcentagem { get; set; }

        public int CompareTo(object obj)
        {
            Filme outro = obj as Filme;
            return Titulo.CompareTo(outro.Titulo);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Filme> filmes =
                JsonConvert.DeserializeObject<IEnumerable<Filme>>
                (File.ReadAllText("filmes.json"));

            var consulta =
                from f in filmes
                select new Filme(f);

            GeraRelatorio("Filmes", consulta);
            Console.WriteLine();
            Console.WriteLine(new String('#', 100));


            //Tarefa 2: obter a lista de filmes de Aventura, executando em PARALELO quando valer apena
            var consulta2 = 
                from f in filmes.AsParallel()
                where f.Genero == "Adventure"
                select new Filme(f);
            GeraRelatorio("Tarefa 2: obter a lista de filmes de Aventura, executando em PARALELO quando valer apena", consulta2);
            Console.WriteLine();
            Console.WriteLine(new String('#', 100));

            //Tarefa 3: obter a lista de filmes de Aventura, executando em PARALELO forçando paralelismo
            var consulta3 =
            from f in filmes.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism)
            where f.Genero == "Adventure"
            select new Filme(f);
            GeraRelatorio("Tarefa 3: obter a lista de filmes de Aventura, executando em PARALELO forçando paralelismo", consulta3);

            //Tarefa 4: obter a lista de filmes de Aventura, executando em PARALELO forçando paralelismo e com grau de paralelismo = 4
            var consulta4 =
            from f in filmes
                .AsParallel()
                .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                .WithDegreeOfParallelism(4)
            where f.Genero == "Adventure"
            select new Filme(f);
            GeraRelatorio("Tarefa 4: obter a lista de filmes de Aventura, executando em PARALELO forçando paralelismo e com grau de paralelismo = 4", consulta4);


            //Tarefa 5: obter a lista de filmes de Aventura, executando em PARALELO na ordem
            var consulta5 =
            from f in filmes
                .AsParallel()
                .AsOrdered()
                .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                .WithDegreeOfParallelism(4)
            where f.Genero == "Adventure"
            select new Filme(f);
            GeraRelatorio("Tarefa 5: obter a lista de filmes de Aventura, executando em PARALELO na ordem", consulta5);


        }

        private static void GeraRelatorio(string tituloRelatorio, IEnumerable<Filme> resultado)
        {
            Console.WriteLine("Relatório: {0}", tituloRelatorio);

            Console.WriteLine("{0,-30} {1,20:N2} {2,20:N2} {3,20:N2} {4,10:P}",
                    "Item",
                    "Faturamento",
                    "Orcamento",
                    "Lucro",
                    "% Lucro");
            Console.WriteLine("{0,-30} {1,20:N2} {2,20:N2} {3,20:N2} {4,10:P}",
                    new string('=', 30),
                    new string('=', 20),
                    new string('=', 20),
                    new string('=', 20),
                    new string('=', 10));

            foreach (var item in resultado)
            {
                Console.WriteLine("{0,-30} {1,20:N2} {2,20:N2} {3,20:N2} {4,10:P}",
                    item.Titulo,
                    item.Faturamento,
                    item.Orcamento,
                    item.Lucro,
                    item.LucroPorcentagem);
            }
            Console.WriteLine();
            Console.WriteLine("FIM DO RELATÓRIO: {0}", tituloRelatorio);
        }
    }
}
