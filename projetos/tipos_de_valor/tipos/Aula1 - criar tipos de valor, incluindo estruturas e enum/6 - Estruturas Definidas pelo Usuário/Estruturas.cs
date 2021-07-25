using System;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            /*
             * Structs são estruturas parecidas com classes 
             * Porém não podem ter método construtor criado sem parametros
             * Não permitem herança, somente aceitam interfaces
             * São um Tipo de valor, então quando são copiados o que é copiado é o valor e não a referência
             */

            var coodenadas = new Coordenadas();//Apesar ser chamado por um construtor sem parametros, não posso ir lá e implementar este construtor
            coodenadas.Latitude = 0.123f;
            coodenadas.Longitude = 0.852f;
            
            var coodenadas2 = new Coordenadas(0.123456f, 1.145f);

            Console.WriteLine($"Coordenadas: {coodenadas}");
            Console.WriteLine($"Coordenadas2: {coodenadas2}");
        }

        interface Gps {
            bool estaNoEmisferioNorte();
        }

        struct Coordenadas : Gps
        {
            public Coordenadas(float Latitude, float Longitude) 
            {
                this.Latitude = Latitude;
                this.Longitude = Longitude;
            }

            public float Latitude { get; set; }
            public float Longitude { get; set; }

            public bool estaNoEmisferioNorte()
            {
                return Latitude > 0;
            }

            override
            public string ToString()
            {
                return $"Latitude: {Latitude}, Longitude: {Longitude}";
            }
        }
    }
}
