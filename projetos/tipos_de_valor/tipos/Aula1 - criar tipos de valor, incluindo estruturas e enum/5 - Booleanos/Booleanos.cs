using System;

namespace certificacao_csharp_roteiro
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            //Brincando com booleanos, eles representam verdadeiro ou falso(true/false);
            int dias = DateTime.Now.Day;
            bool ehPar = (dias % 2) == 0;

            if (ehPar) 
            {
                Console.WriteLine($"{dias} é um número par");
            }
            else 
            {
                Console.WriteLine("{dias} é um número ímpar");
            }

        }
    }
}
