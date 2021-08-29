using System;

namespace _02._5.enumerar
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA:
            //======
            //Imprimir o documento no console, destacando
            //as letras maiúsculas no texto

            string documento = GetDocumento();
            Console.WriteLine(documento);

            //Char c = documento[0];
            //Console.WriteLine(c);

            foreach (var c in documento)
            {
                if (char.IsUpper(c))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.Write(c);
            }

            Console.ReadKey();
        }

        private static string GetDocumento()
        {
            return "Uma cadeia de caracteres é uma coleção sequencial de caracteres que é usada para representar texto. Um objeto String é uma coleção sequencial de objetos System.Char que representam uma cadeia de caracteres; um System.Char objeto corresponde a uma unidade de código UTF-16. O valor de objeto String é o conteúdo da coleção sequencial de objetos System.Char cujo valor é imutável. Ou seja, ele é somente leitura.";
        }
    }
}
