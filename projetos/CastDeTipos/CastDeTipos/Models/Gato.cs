using System;

namespace models{
    class Gato: Animal
    {
        internal override void Andar()
        {
            Console.WriteLine("Gato.Andar");
        }

        internal new void Dormir()
        {
            Console.WriteLine("Gato.Dormir");
        }
    } 
}