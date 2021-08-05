using System;

namespace PropriedadesEAcessadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1000);
            Console.WriteLine(funcionario.Salario);

            /*
                Acessadores:
                    Private => Disponível apenas dentro da classe;
                    protected => Disponível apenas na classe e onde sua classe estiver implementada como classe base;
                    internal => Disponível em todo assembly/projeto;
                    public => Nível mais permissível possível, até em outros assembly/projetos
            */
        }
    }

    class Funcionario
    {
        public Funcionario(decimal salario)
        {
            if (salario < 0)
            {
                throw new ArgumentOutOfRangeException("salário não pode ser negativo");
            }
            this.Salario = salario;//Note que  apesar da Property não conter um set, ela ainda é acessível no construtor
        }

        public decimal Salario //encapsulamento do campo salario
        {
            get;
        }
        
    }
}
