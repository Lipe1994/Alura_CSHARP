using System;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 20;
            Console.WriteLine($"pontuacao: {pontuacao}");

            /*
             * Object é o tipo  mais básico do C#, por definição é o ancestral de todas as classes
             */

            Object myObject = pontuacao;
            Console.WriteLine($"pontuacao(myObject): {myObject}");

            myObject = new Jogador();
            Jogador jogador = (Jogador) myObject;//Em classes(Tipos de referencia) é preciso fazer um cast
            Console.WriteLine($"jogador pontuacao: {jogador.Pontuacao}");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
