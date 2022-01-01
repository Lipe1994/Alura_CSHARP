using System;
using System.Collections.Generic;

namespace sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //SortedList são um tipo que internamente implementam Dictionary porém ela também tem uma lista automática responsavel por ordenar os items com base em sua chave
            //, e não utilizam hash para se organizar, utilizam a própria chave(através desta lista interna) no lugar do código de dispersão
            var dicionarioDeFilmes = new SortedList<int, Filme>();

            dicionarioDeFilmes.Add(1, esperanca);
            dicionarioDeFilmes.Add(20, esperanca);
            dicionarioDeFilmes.Add(4, ameaca);
            dicionarioDeFilmes.Add(3, retorno);
            dicionarioDeFilmes.Add(2, imperio);
            //dicionarioDeFilmes.Add(40, ameaca); //caso mesma chave for inserida será lançada uma exception

            Imprimir(dicionarioDeFilmes);

            dicionarioDeFilmes[1] = ameaca; // atualizando usando indice
            Imprimir(dicionarioDeFilmes);

            dicionarioDeFilmes[5] = ameaca; // Adicionando usando indice
            Imprimir(dicionarioDeFilmes);

            Imprimir(dicionarioDeFilmes.Keys);// imprimindo lista de chaves

            Imprimir(dicionarioDeFilmes.Values); // imprimindo lista de valores

            //Console.WriteLine(dicionarioDeFilmes[60]); //Caso forneça um indice que não existe para pegar um valor, resultará em exception(The given key '60' was not present in the dictionary.')...

            //Obtendo dados com mais segurança, sem correr risco caso indice não exista resultará em null
            Console.WriteLine(dicionarioDeFilmes.GetValueOrDefault(60));
            Console.WriteLine(dicionarioDeFilmes.GetValueOrDefault(4));

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
