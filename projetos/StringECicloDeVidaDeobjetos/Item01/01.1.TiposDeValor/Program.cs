using System;

namespace _01._1.TiposDeValor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para entender como dotnet lida com tipos de valor execute este programa e observe a "call stack"
            //O dotnet guarda informações em uma stack, cada metodo tem seu stack container na stack e a metida que os métodos vão sendo chamados e retornados os mesmos são desempilhados e destruídos sem a necessidade do GC
            Metodo1();
            Console.ReadKey();
        }

        static void Metodo1()
        {
            Metodo2(12);
            Console.WriteLine("Saindo do método 1...");
        }

        static void Metodo2(int dados)
        {
            int multiplicador = 2;
            Console.WriteLine("O valor é: "
                + dados.ToString());
            Metodo3(dados * multiplicador);
        }

        static void Metodo3(int dados)
        {
            Console.WriteLine("O dobro é: "
                + dados.ToString());
        }
    }
}
