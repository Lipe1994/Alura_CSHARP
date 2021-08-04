using System;
using System.Collections.Generic;

namespace certificacao_csharp_roteiro
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            //Conversões entre dynamics

            dynamic d1 = 7;
            dynamic d2 = "Certificação C#";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>(){123, 456, 789};

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            //Note que como dynamics só assumem seu tipo na execução, é responsabilidade do desenvolvedor fazer a conversão correta
            int c1 = d1;
            string c2 = d2;
            DateTime c3 = d3;
            List<int> c4 = d4;

            //int c5 =  d2;//Dará erro em execução

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

        }
    }
}
