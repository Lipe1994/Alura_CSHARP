using System;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 26;
            Console.WriteLine(idade);


            int copiaIdade = idade;
            Console.WriteLine($"idade: {idade}, copia da idade: {copiaIdade}");

            idade = 27;
            
            Console.WriteLine($"alterando a idade: {idade}, copia idade permanece com valor: {copiaIdade} por se tratar de um tipo de valor");


            //tipos de valor versão nullable
            int? idade2 = null;
            System.Nullable<int> idade3 = null;
            
            
        }
    }
}
