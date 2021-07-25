using System;

namespace certificacao_csharp_roteiro
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            /*
             * dynamic é um recurso dotnet que diferentemente do Tipo object, 
             * ele não é verificaco em tempo de compilação e fica na responsabilidade do desenvolvedor não chamar 
             * métodos ou propriedades que não existem pois dará erro durante a execução
             * 
             * Variáveis do tipo dynamic são compiladas como sendo object
             * Dynamic existe somente em tempo de compilação
             */

            dynamic aluno = new
            {
                Idade = 26,
                Nome = "Filipe Ferreira"
            };

            Console.WriteLine($"Aluno: {aluno.Nome}, Idade: {aluno.Idade}");
        }
    }
}
