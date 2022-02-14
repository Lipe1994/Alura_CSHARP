using System;

namespace action
{
    class Program
    {
        static void Main(string[] args)
        {
            var campanhia = new Campanhia();

            campanhia.OnRingToBell += RingToBell;
            campanhia.OnRingToBell += RingToBell2;

            campanhia.Tocar();

            Console.WriteLine("\r\n Chamando Action/Delegate diretamente =>");

            campanhia.OnRingToBell?.Invoke();//Para evitar este tipo de chamada direta usa-se o event EventHandle

            Console.ReadKey();
        }

        static void RingToBell() 
        {
            Console.WriteLine("Tocando campanhia.");
        }

        static void RingToBell2()
        {
            Console.WriteLine("Tocando campanhia. (2)");
        }

        class Campanhia
        {
            public Action OnRingToBell { get; set; }

            public void Tocar() 
            {
                OnRingToBell?.Invoke();
            }
        }
    }
}
