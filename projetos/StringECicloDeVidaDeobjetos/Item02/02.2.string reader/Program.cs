using System;
using System.IO;

namespace _02._2.string_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA:
            //======
            //1) Ler sequencialmente a lista de ingredientes
            //linha a linha.
            //2) Cada Linha deve começar com um caracter "•" e um espaço

            /*
             StringReader é uma herdeiro de TextReader, especializado em ler strings em formato de texto com quebras de linha,
                ele carrega um texto e consegue entregar completo ou linha a linha
             */

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string ingredientes = GetIngredientes();

            using (StringReader stringReader = new StringReader(ingredientes))
            {
                string line;
                while ((line = stringReader.ReadLine()) != null)
                {
                    Console.WriteLine("• " + line);
                }
            }

            Console.ReadKey();
        }

        private static string GetIngredientes()
        {
return
@"3 cenouras médias raspadas e picadas
3 ovos
1 xícara de óleo
2 xícaras de açúcar
2 xícaras de farinha de trigo
1 colher(sopa) de fermento em pó
1 pitada de sal";
        }
    }
}
