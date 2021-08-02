using System;
using models;

namespace certificacao_csharp_roteiro
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double divida =  1_234_567_890.123;
            long copia = (long) divida; //Este parenteses representa o Cast Explícito, estamos garantindo que ele pode converter e responsabilidade é nossa. Pois por o double ser maior que o long pode haver perca de precisão.

            Console.WriteLine($"Divida: {divida}, Cópia: {copia}");

            IAnimal gato = new Gato(){Nome = "Gato"};
            Animal animal = (Animal) gato;

            animal.Andar();//Nome que mesmo com Cast explícito a conversão respeita o 'override'
            animal.Dormir();
            Console.WriteLine($"Animal {animal.GetType()}");
        }
    }
}
