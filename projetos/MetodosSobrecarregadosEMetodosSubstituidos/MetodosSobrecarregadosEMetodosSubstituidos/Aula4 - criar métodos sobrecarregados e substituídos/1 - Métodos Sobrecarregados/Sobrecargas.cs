using System;


namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;
            Console.WriteLine($"Volume do Cubo: {Volume(lado)}");

            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;
            Console.WriteLine($"Volume do Cilindro: {Volume(raio, altura)}");

            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            Console.WriteLine($"Volume do Prisma: {Volume(largura, altura, profundidade)}");
        }

        double Volume(int lado)
        {
            return Math.Pow(lado,3);
        }

        double Volume(double raio, int altura)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double Volume(long largura, int altura, int profundidade)
        {
            return largura * profundidade * altura;
        }
    }
}
