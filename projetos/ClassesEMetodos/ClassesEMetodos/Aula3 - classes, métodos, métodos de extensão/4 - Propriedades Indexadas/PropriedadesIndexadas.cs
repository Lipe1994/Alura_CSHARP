using System;
using System.Collections.Generic;
using System.Linq;

namespace certificacao_csharp_roteiro
{
    class PropriedadesIndexadas : IAulaItem
    {
        public void Executar()
        {
            var sala = new Sala();
            sala.SetReserva("D01", new ClienteCinema("Maria de Souza"));
            sala.SetReserva("D02", new ClienteCinema("José da Silva"));

            // Usando propriedades indexadas
            sala["D03"] = new ClienteCinema("Filipe Ferreira");
            sala["D04"] = new ClienteCinema("Laura Ferreira");

            sala.ImprimirReservas();
        }
    }

    class ClienteCinema
    {
        public ClienteCinema(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }

    class Sala
    {
        private readonly IDictionary<string, ClienteCinema> reservas
            = new Dictionary<string, ClienteCinema>();

        public ClienteCinema GetReserva(string codigoAssento)
        {
            return reservas[codigoAssento];
        }

        public void SetReserva(string codigoAssento, ClienteCinema value)
        {
            reservas.Add(codigoAssento, value);
        }

        public ClienteCinema this[string codigoAssento]{//<-- Propriedade indexada :D
            set {
                reservas[codigoAssento] = value;
            }
            get => reservas[codigoAssento];
        }

        public void ImprimirReservas()
        {
            Console.WriteLine("Assentos Reservados");
            Console.WriteLine("===================");
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"{reserva.Key} - {reserva.Value}");
            }
        }
    }
}
