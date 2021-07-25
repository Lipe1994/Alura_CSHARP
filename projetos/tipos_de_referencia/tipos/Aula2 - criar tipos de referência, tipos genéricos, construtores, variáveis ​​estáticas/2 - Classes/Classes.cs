using System;

namespace certificacao_csharp_roteiro
{
    class Classes : IAulaItem
    {
        public void Executar()
        {
            /*
             * Classes são mais robustas que structs e permitem herança, abstração e são tipos de referência
             */
            var coordenadas = new Coordenadas()
            {
                Latitude = 1.1256f,
                Longitude = 0.1256f
            };
            Console.WriteLine($"Coordenadas: {coordenadas}");

            var coordenadasComHoraDaLeitura = new CoordenadasComHora()
            { 
                Longitude = 1.25696f,
                Latitude = 0.45866f,
                HoraDaLaitura = DateTime.Now
            };
            Console.WriteLine($"Coordenadas: {coordenadasComHoraDaLeitura}");
        }

        //classe base
        class Coordenadas 
        {
            public float Latitude { get; set; }
            public float Longitude { get; set; }

            public override string ToString()
            {
                return $"Latitude: {Latitude}, Longitude: {Longitude}";
            }
        }

        //classe que recebe a herança
        class CoordenadasComHora : Coordenadas
        {
            public DateTime HoraDaLaitura { get; set; }

            public override string ToString()
            {
                return $"Latitude: {Latitude}, Longitude: {Longitude}, Hora da leitura: {HoraDaLaitura}";
            }
        }
    }
}
