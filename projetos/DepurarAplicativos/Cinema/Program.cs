using Cinema.Dados;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Program
    {
        private const string DatabaseServer = "(LocalDB)\\MSSQLLocalDB";
        private const string MasterDatabase = "master";
        private const string DatabaseName = "Cinema";

        static async Task Main(string[] args)
        {
            var assemblyFullName = typeof(Cinema.Program).Assembly.FullName;
            Console.WriteLine($"Cinema => {assemblyFullName}");

            assemblyFullName = typeof(Cinema.Dados.CinemaDB).Assembly.FullName;
            Console.WriteLine($"Cinema.Dados => {assemblyFullName}");

            var cinemaDB = new CinemaDB(DatabaseServer, MasterDatabase, DatabaseName);

            await cinemaDB.CriarBancoDeDadosAsync();

            IList<Filme> filmes = await cinemaDB.GetFilmes();

            foreach (var filme in filmes)
            {
                Console.WriteLine("Diretor: {0} Titulo: {1}", filme.Diretor, filme.Titulo);
            }

            Console.ReadKey();
        }

    }
}
