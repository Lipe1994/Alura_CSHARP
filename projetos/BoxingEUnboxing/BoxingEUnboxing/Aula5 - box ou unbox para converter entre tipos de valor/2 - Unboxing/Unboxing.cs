using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;

            object boxed = numero; //Isso é uma operação de Boxing, o valor 57(que é tipo de valor) vai ser 'encaixotado' no objeto
            Console.WriteLine($"Valor da variável boxed => {boxed}");

            int unboxed = (int) boxed;// Através do cast é possível desempacotar este valor novamente, Unboxed
            Console.WriteLine($"Valor unboxed -> {unboxed}");
        }
    }
}
