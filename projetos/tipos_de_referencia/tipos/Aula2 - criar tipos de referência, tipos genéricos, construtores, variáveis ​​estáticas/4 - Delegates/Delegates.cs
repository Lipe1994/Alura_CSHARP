using System;

namespace certificacao_csharp_roteiro
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    delegate double Calcular(double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }

        static double Triplicar(double input)
        {
            return input * 3;
        }

        public static void Executar()
        {

            //Executa diretamente o método
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            //Executa diretamente o método
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            //Delegate é uma forma que temos no C# de carregar métodos em 'variáveis' quase da maneira que o JS faz,
            //porém no C# por ser de tipagem forte, precisamos do delegate que é uma assinatura do método
            Calcular calcular = Duplicar;
            Console.WriteLine($"Duplicar(7.5): {calcular(7.5)}");
            
            calcular = Triplicar;
            Console.WriteLine($"Triplicar(7.5): {calcular(7.5)}");

            //outra possibilidade é carregar métodos anônimos
            calcular = delegate (double input)
            {
                return input * 4;
            };
            Console.WriteLine($"Quadruplicar (7.5): {calcular(7.5)}");
            
            calcular = (input)=> input * 5;// Com lambda também rola :D
            Console.WriteLine($"Quintuplicar (7.5): {calcular(7.5)}");
        }
    }
}
