using System;
using models;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;// Veja que neste trecho o valor do Int32 será convertido para Int64, de maneira automática, este é o Cast implícito
            //Note que cast implícito funciona entre um long receber um int porque não tem risco de acontecer perda de dados, o contrário teria que ser explícito


            Console.WriteLine($"Inteiro: {inteiro.GetType()}");
            Console.WriteLine($"Inteiro longo: {inteiroLongo.GetType()}");
            Console.WriteLine($"\r\n");

            Gato gato = new Gato(){
                Nome = "Gato",
            };
            //Cast implícito com interface ou interface de uma classe base e com a classe base, também é possível
            IAnimal ianimal = gato;
            Animal animal = gato;

            //animal = ianimal; //isso não daria certo

            Console.WriteLine($"gato nome: {gato.Nome}, IAnimal nome: {ianimal.Nome}, Animal nome: {animal.Nome}");
            Console.WriteLine($"\r\n");


            //Embora o getType aqui mostre o tipo Gato para todo mundo a classe base e a interface usarão parametros e metodos da classe  base.
            //Se o comportamento desejado for o da classe filha, deve-se usar modificador virtual ou abstract no membro de mesmo nome na classe base.

            Console.WriteLine($"Gato: {gato.GetType()}");
            Console.WriteLine($"IAnimal: {ianimal.GetType()}");
            Console.WriteLine($"Animal: {animal.GetType()}");
            Console.WriteLine($"\r\n"); 

            gato.Andar();
            gato.Dormir();
            Console.WriteLine($"\r\n");

            animal.Andar();
            animal.Dormir();


        }
    }
}

