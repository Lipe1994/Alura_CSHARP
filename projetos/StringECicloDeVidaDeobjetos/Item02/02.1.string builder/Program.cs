using System;
using System.Text;

namespace _02._1.string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
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
