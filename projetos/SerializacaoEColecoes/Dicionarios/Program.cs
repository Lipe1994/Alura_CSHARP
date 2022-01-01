using System;
using System.Collections.Generic;

namespace dicionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //dicionario, dicionarios criam seu método getHashCode(código de dispersão ou código de espalhamento ) com base na sua chave...
            var dicionarioDeFilmes = new Dictionary<int, Filme>();

            dicionarioDeFilmes.Add(10, esperanca);
            dicionarioDeFilmes.Add(20, imperio);
            dicionarioDeFilmes.Add(30, retorno);
            dicionarioDeFilmes.Add(40, ameaca);
            //dicionarioDeFilmes.Add(40, ameaca); //caso mesma chave for inserida será lançada uma exception

            Imprimir(dicionarioDeFilmes);

            dicionarioDeFilmes[10] = ameaca; // atualizando usando indice
            Imprimir(dicionarioDeFilmes);

            dicionarioDeFilmes[50] = ameaca; // Adicionando usando indice
            Imprimir(dicionarioDeFilmes);

            Imprimir(dicionarioDeFilmes.Keys);// imprimindo lista de chaves

            Imprimir(dicionarioDeFilmes.Values); // imprimindo lista de valores

            //Console.WriteLine(dicionarioDeFilmes[60]); //Caso forneça um indice que não existe para pegar um valor, resultará em exception(The given key '60' was not present in the dictionary.')...

            //Obtendo dados com mais segurança, sem correr risco caso indice não exista resultará em null
            Console.WriteLine(dicionarioDeFilmes.GetValueOrDefault(60));
            Console.WriteLine(dicionarioDeFilmes.GetValueOrDefault(40));
        }

        static void Imprimir<T>(IEnumerable<T> enumerable) 
        {
            Console.WriteLine($"\r\n{string.Join(",\r\n", enumerable)}\r\n");
        }
    }

    public class Filme
    {
        public Filme(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }
    }
}
