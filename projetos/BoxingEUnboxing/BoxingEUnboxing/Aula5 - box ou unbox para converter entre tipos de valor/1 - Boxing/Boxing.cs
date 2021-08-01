using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;

            object boxed = numero; //Isso é uma operação de Boxing, o valor 57(que é tipo de valor) vai ser 'encaixotado' no objeto

            Console.WriteLine($"Valor da variável boxed => {boxed}");

            Console.WriteLine($"boxing usando string {string.Concat(true, numero, "boxing")}");// Note que o dotnet vai fazer boxing nos dois primeiros parametros, o ultimo já é um tipo de referência(string)
        }
    }
}
