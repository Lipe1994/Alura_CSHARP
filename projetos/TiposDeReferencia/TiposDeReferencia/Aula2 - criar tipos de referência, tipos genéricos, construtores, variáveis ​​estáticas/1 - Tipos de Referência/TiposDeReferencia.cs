using System;

namespace certificacao_csharp_roteiro
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            //Tipos de referência são aqueles que envés de copiar o valor eles copiam endereço de memória(Como ponteiros)
            var pessoa = new Pessoa();
            pessoa.Idade = 27;
            pessoa.Nome = "João";

            Console.WriteLine($"pessoa - Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");

            var pessoa2 = pessoa;
            pessoa2.Idade = 26;
            pessoa2.Nome = "Filipe Ferreira";

            Console.WriteLine($"pessoa - Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
            Console.WriteLine($"pessoa2 - Nome: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
        }
    }

    class Pessoa 
    {
        public int Idade { get; set; }

        public string Nome { get; set; }
    }
}
