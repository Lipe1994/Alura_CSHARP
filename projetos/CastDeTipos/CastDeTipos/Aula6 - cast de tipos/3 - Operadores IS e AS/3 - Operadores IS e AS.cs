using System;
using models;

namespace certificacao_csharp_roteiro
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Fruta cliente = new Fruta(){Nome = "Abacate"};

            Console.WriteLine($"\r\n");
            Console.WriteLine($"1ª Maneira");
            Acao1(animal);
            Acao1(gato);
            //Acao1(cliente);//Como a Acao1 converte sem seguranã dará erro em tempo de execução

            Console.WriteLine($"\r\n");
            Console.WriteLine($"2ª Maneira");
            Acao2(animal);
            Acao2(gato);
            Acao2(cliente);
            
            Console.WriteLine($"\r\n");
            Console.WriteLine($"3ª Maneira");
            Acao3(animal);
            Acao3(gato);
            Acao3(cliente);

            Console.WriteLine($"\r\n");
            Console.WriteLine($"4ª Maneira");
            Acao4(animal);
            Acao4(gato);
            Acao4(cliente);
        }

        //4 Maneiras de fazer Cast Explícito
        public void Acao1(object obj)//Cast sem segurança
        {

            Animal animal = (Animal)obj;
            animal.Dormir();
            animal.Andar();
        }
        public void Acao2(object obj)
        {
            Animal animal = null;

            if(obj is IAnimal)//poderia ser Animal também, o Is é um verificador
            {
                animal = (Animal) obj;

            }

            if(animal == null)
            {
                Console.WriteLine($"Não é um animal");
                return;
            }

            animal.Dormir();
            animal.Andar();
        }
        public void Acao3(object obj)
        {
            Animal animal = obj as Animal;// 'as' faz um Cast com segurança, caso obj não seja um Animal a variável ficará null


            if(animal == null)
            {
                Console.WriteLine($"Não é um animal");
                return;
            }

            animal.Dormir();
            animal.Andar();
        }

        public void Acao4(object obj)
        {
            if(obj is Animal animal)//Neste caso o 'is' compara se é um Animal, depois instancia a conversão na variável 'animal' no scopo do if :D
            {
                animal.Dormir();
                animal.Andar();
                return;
            }
            Console.WriteLine($"Não é um animal");

        }
    }

    class Fruta
    {
        public string Nome { get; set; }
    }
}
