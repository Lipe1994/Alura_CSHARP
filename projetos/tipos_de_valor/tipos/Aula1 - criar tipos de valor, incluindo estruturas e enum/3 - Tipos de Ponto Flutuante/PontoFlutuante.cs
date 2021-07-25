using System;

namespace certificacao_csharp_roteiro
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            //Números flutuantes abrangem valores muito maiores que os inteiros ==> 

            Console.WriteLine($"long.MinValue: { long.MinValue}");
            Console.WriteLine($"long.MaxValue: { long.MaxValue}");

            Console.WriteLine($"float.MinValue: { float.MinValue}");
            Console.WriteLine($"float.MaxValue: { float.MaxValue}");

            Console.WriteLine($"double.MinValue: { double.MinValue}");
            Console.WriteLine($"double.MaxValue: { double.MaxValue}");

            //para representar números gigantes usa-se notação cientifica
            float massaDaTerra = 5.972e24f;
            double massaDaTerra2 = 5.972e24;

            //em operações com números de tipos diferentes o C# sempre converte para o tipo de maior abrangencia
            int x = 3;
            double y = 5;
            var result = x * y;
            Console.WriteLine($"x*y={result}, type={result.GetType()}");
            
        }
    }
}
