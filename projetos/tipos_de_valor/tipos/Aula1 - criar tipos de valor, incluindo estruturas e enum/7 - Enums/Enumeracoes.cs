using System;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            /*
                Usados para representar familias de valores constantes, as enums também são um tipo de valor
             */

            DiasDaSemana diaDaSemana = DiasDaSemana.sab;
            Console.WriteLine(diaDaSemana);

            //enums também podem ser adicionadas em uma variável usando operador '|', desde que seus valores sejam representados por bits(0,1,2,4,8,16,32...)
            DiasDaSemanaShort diasDaSemana2 = DiasDaSemanaShort.ter | DiasDaSemanaShort.sab | DiasDaSemanaShort.dom;
            Console.WriteLine(diasDaSemana2);// os valores das respectivas flags serão somadas = 49

            // através da anotation [Flags] declarada na enum, o ToString dessa variável poderia ser um conjunto de flags... 
            //DiasDaSemanaShort diasDaSemana3 = DiasDaSemanaShort.ter | DiasDaSemanaShort.sab | DiasDaSemanaShort.dom;
            //Console.WriteLine(diasDaSemana3);

        }

        enum DiasDaSemana
        {
            seg,
            ter,
            qua,
            qui,
            sex,
            sab,
            dom
        }

        //Seus valores podem também ser ordenados manualmente(por default seria 0,1,2,3...)
        enum DiasDaSemanaComValoresManual
        {
            seg = 1,
            ter = 2,
            qua = 3,
            qui = 4,
            sex = 5,
            sab = 6,
            dom = 7,
        }

        //Por dedault enums são flags com valor do tipo inteiro mais isso pode ser alterado
        //[Flags]
        enum DiasDaSemanaShort : short
        {
            seg = 0,
            ter = 1,
            qua = 2,
            qui = 4,
            sex = 8,
            sab = 16,
            dom = 32
        }
    }
}
