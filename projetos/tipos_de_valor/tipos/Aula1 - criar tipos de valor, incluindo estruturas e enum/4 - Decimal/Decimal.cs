using System;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {

            /* float e double internamente trabalham com uma representação binária do número e para 
             * alcançar uma representação binária é necessário um arredondamento
             */

            //EX.: 
            double a = 10.10;
            double b = 20.20;
            Console.WriteLine($"Descobrindo se float/double (10.10 + 20.20 = 30.30) => {a + b == 30.30}");
            Console.WriteLine($"Observando no debug nota-se que o valor de  a+b é 30.299999999999997. teste=>{a + b == 30.299999999999997}");

            /*
             *Para trabalhar com mais precisão nessa questão(valores monetários por exemplo) é melhor usar decimal que sua representação
             * interna reflete um decimal arredondado
             */
            //EX.:
            decimal x = 10.10m;
            decimal y = 20.20m;
            Console.WriteLine($"Descobrindo se os decimals (10.10 + 20.20 = 30.30) => {x + y == 30.30m}");
        }
    }
}
