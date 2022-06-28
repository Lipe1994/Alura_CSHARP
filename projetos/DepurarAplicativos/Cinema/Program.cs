using Cinema.Dados;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

//Brincando com "symbols of compilattion" e Atributos
/*
    * #if é um if que é havaliado no momento da compilação, caso seja false o bloco que ele valida nem aparecerá no assemblie de linguagem intermediaria
    * #elif é  um else if
    * #endif final dos condicionais
    * 
    * #warning seguido de texto indicará uma mensagem no momento da compilação com warning
    * #error seguido de mensagem gerará erro de compilação e imperirá a mesma
    * 
    * #line hidden faz o debugger ignorar os códigos abaixo
    * #line default finaliza as linhas ignoradas pelo debugger
    */



#if MODO_DEBUG
            Console.WriteLine("Rodando em Debug");
            mostraFilmes(filmes);

#line hidden
            Console.WriteLine("Rodando em Debug");
#line default

#warning Gerando uma warning :D
#elif MODO_RELEASE
        Console.WriteLine("Rodando em Release");
#error Não quero que compile, porque sim!
#endif


            Console.ReadKey();
        }


        [DebuggerStepThrough]// este atribudo faz o debugger não entrar nesse método, EX.: se em debugger o dev pessionar F11 não entrará neste método
        [Obsolete("Em vez de mostrarFilmes(), use o mostrarFilmesComFormatacao")]
        static void mostraFilmes(IList<Filme> filmes) 
        {
            foreach (Filme filme in filmes) 
            {
                Console.WriteLine($"Filme => {Newtonsoft.Json.JsonConvert.SerializeObject(filme)}");
            }
        }

        static void mostraFilmesComFormatacao(IList<Filme> filmes)
        {
            foreach (Filme filme in filmes)
            {
                Console.WriteLine($"Filme => {Newtonsoft.Json.JsonConvert.SerializeObject(filme, Formatting.Indented)}");
            }
        }

    }
}
