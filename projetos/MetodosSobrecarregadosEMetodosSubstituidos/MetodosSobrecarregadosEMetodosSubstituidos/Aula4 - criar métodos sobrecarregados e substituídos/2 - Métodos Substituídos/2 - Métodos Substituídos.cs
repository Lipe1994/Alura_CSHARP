using System;


namespace certificacao_csharp_roteiro
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
            Gato gato = new Gato(){
                Nome = "Gato"
            };
            gato.Beber();
            gato.Comer();
            gato.Andar();

            Console.WriteLine("\n");

            Animal animal = new Gato() { Nome = "Animal" };
            animal.Beber();
            animal.Comer();
            animal.Andar();
        }
    }

    class Animal
    {
        public String Nome { get; set; }

        public void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }

        public virtual void Comer() //Este virtual garante que se eu jogar um objeto herdado na na implementação desta classe base, o metodo da classe base será substituído 
        {
            Console.WriteLine("Animal.Comer");
        }

        public void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }

    }

    class Gato : Animal
    {
        public new void Beber()
        {
            Console.WriteLine("Gato.Beber");
        }

        public override void Comer()//override para reescrever o método da classe base, pois ele será substituído
        {
            Console.WriteLine("Gato.Comer");
        }

        public new void Andar()
        {
            Console.WriteLine("Gato.Andar");
        }
    }
}