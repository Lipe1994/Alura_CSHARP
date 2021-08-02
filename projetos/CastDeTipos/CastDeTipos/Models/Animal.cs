using System;

namespace models{
    internal class Animal: IAnimal
    {
        public string Nome { get; set; }

        internal virtual void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }

        internal void Dormir()
        {
            Console.WriteLine("Animal.Dormir");
        }
    } 
}