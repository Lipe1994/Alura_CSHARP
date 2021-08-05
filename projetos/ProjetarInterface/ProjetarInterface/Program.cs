using System;

namespace ProjetarInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note que a interface IEletrodomestico, pode instancias qualquer classe que o implemente e disponibliza os métodos ligar e desligar
            IEletroDomestico eletro1 = new Televisao();
            IEletroDomestico eletro2 = new Abajur();
            IEletroDomestico eletro3 = new Lanterna();
            IEletroDomestico eletro4 = new Radio();
        }
    }

    interface IEletroDomestico
    {
        void Desligar();
        void Ligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    interface IRadio
    {
        double Frequencia{ get; set; }
    }

    class Televisao: IEletroDomestico, IRadio
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double Frequencia{ get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
            if (Ligou != null)
            {
                Ligou(this, new EventArgs());
            }
        }
    }

    class Abajur : IEletroDomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna: IEletroDomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio: IEletroDomestico, IRadio
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double Frequencia{ get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
