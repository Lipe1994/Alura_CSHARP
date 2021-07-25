using System;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            /*
             *Interfaces são contratos garantindo que a classe que as implemente cumpra suas exigencias
             *Isso da a possíbilidade de uma mesma interface representar várias classes, ajuda na hora de fazer DI...
             */

            IEletrodomestico eletrodomestico = new Televisao();

            eletrodomestico.Ligar();
            eletrodomestico.Desligar();
            
            eletrodomestico = new Abajur();

            eletrodomestico.Ligar();
            eletrodomestico.Desligar();


        }
    }

    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
    }

    interface IIluminacao 
    {
        double PotenciaDaLampada { get; set; }
    }

    class Televisao : IEletrodomestico
    {
        public void Desligar()
        {
            Console.WriteLine($"Desligando {typeof(Televisao)}");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {typeof(Televisao)}");
        }
    }

    class Abajur : IEletrodomestico, IIluminacao //Detalhe: uma classe pode implementar mais de uma interface
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
            Console.WriteLine($"Desligando {typeof(Abajur)}");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {typeof(Abajur)}");
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao 
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
            Console.WriteLine($"Desligando {typeof(Lanterna)}");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {typeof(Lanterna)}");
        }
    }

    class Radio : IEletrodomestico
    {
        public void Desligar()
        {
            Console.WriteLine($"Desligando {typeof(Radio)}");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {typeof(Radio)}");
        }
    }
}
