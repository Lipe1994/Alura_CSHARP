using System;
using System.Text;

namespace _02._1.string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             O StringBuilder mantém 1 instancia na heap com a cadeia de caracteres, e em cada concatenação ele atualiza essa cadeia de caracteres, 
                porém quando essa cadeia chega ao limite 
                ele instancia uma nova cadeia de caracteres, ele é uma boa solução pra quando o algoritimo precisa de muitas concatenações.
             */
            StringBuilder materias = new StringBuilder();
                materias.Append("Português");
                Console.WriteLine(materias);
                materias.Append(", Matemática");
                Console.WriteLine(materias);
                materias.Append(", Geografia");
                Console.WriteLine(materias);
            Console.ReadKey();
        }
    }
}
