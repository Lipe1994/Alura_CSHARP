using System;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            //Tipos integrais

            int idade = 15;

            // Isso mesmo apesar de representar uma letra, internamente o char é um é um número com 2 bytes
            char resposta = 'S';

            //0 - 255
            byte nivelDeAzul = 0xF;

            //System.Int16
            short passageirosNoVoo = 230;

            //System.Int32
            int populacao = 1500;

            //System.Int64
            long populacaoDoBrasil = 207_660_929;

            //System.SByte
            //byte com valores negativos
            sbyte nivelDeBrilho = -127;

            //System.UInt16
            //short sem números negativos, o U vem de unsign(sem sinal)
            ushort passageirosNoNavio = 230;

            //System.UInt32
            uint estoque = 1500;
            
            //System.UInt64
            ulong populacaoDoMundo = 7_000_000_000;

            Console.WriteLine($"resposta: {resposta}");

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosNoVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

            Console.WriteLine($"niveldeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"passageirosNoNavio: {passageirosNoNavio}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");
            

        }
    }
}
