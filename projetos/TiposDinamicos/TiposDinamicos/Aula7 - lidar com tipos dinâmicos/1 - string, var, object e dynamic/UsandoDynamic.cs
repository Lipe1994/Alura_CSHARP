using System;


namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            //Variáveis com tipos definidos na compilação
            string s = "Certificação C#";
            var v = "Certificação C#";
            object o = "Certificação C#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);
            Console.WriteLine("\r\n");

            Console.WriteLine($"s => {s.GetType()}");
            Console.WriteLine($"v => {v.GetType()}");
            Console.WriteLine($"o => {o.GetType()}");
            Console.WriteLine("\r\n");

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper(); //Precisa de Cast para acessar operações do tipo atual 
            Console.WriteLine("\r\n");

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);
            Console.WriteLine("\r\n");

            //s = 10; //não muda tipo
            //v = 10; //não muda tipo
            o = 10;//muda o tipo
            o = ((int) o) +1; //Continua precisando de Cast para acessar operações do seu tipo atual,
            Console.WriteLine($"o => {o.GetType()}");
            Console.WriteLine("\r\n");

            //Tipo definido na execução
            dynamic d = "Certificação C#";
            Console.WriteLine(d);
            Console.WriteLine("\r\n");

            Console.WriteLine($"d => {d.GetType()}");

            d = 10;//Não precisa de Cast para mudar tipo
            d = 10 + 2;

            Console.WriteLine($"d => {d.GetType()}");


        }
    }
}
