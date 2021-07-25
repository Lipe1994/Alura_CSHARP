using System;

namespace certificacao_csharp_roteiro
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            string a = "bom dia";
            string b = a;

            /*
             * String são tipos de referência que representam um conjunto de caracteres, e tem um atalho 'string'
             */

            b = "boa tarde";

            //Strings tem um comportamento diferente dos Tipos de referência normais, 
            //pois ela faz uma cópia de valor quando, vide no teste... Mais é um tipo de referência
            Console.WriteLine($"a => {a}, b => {b}");
        }
    }
}
