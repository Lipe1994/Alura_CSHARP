using System;

namespace InterfaceExplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "josé da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            /*
             Interfaces explicitas podem ser usadas quando a classe implementa mais de uma interface, e com membros de mesmo nome, vc pode usar uma técnica de Cast para 
                referenciar as implementações
             */

            ((IFuncionario)funcionario).CargaHorariaMensal = 168;
            ((IPlantonista)funcionario).CargaHorariaMensal = 30;

            funcionario.EfeturarPagamento();
            funcionario.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };


            ((IFuncionario)funcionario).GerarCracha();
            ((IPlantonista)funcionario).GerarCracha();
        }
    }

    interface IPlantonista 
    {
        void GerarCracha();
        int CargaHorariaMensal { get; set; }
    }

    interface IFuncionario
    {
        string CPF { get; set; }
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }

        event EventHandler CrachaGerado;

        void GerarCracha();

        decimal Salario { get; }
        int CargaHorariaMensal { get; set; }

        void EfeturarPagamento();
    }

    class Funcionario : IFuncionario, IPlantonista
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public event EventHandler CrachaGerado;

        void IFuncionario.GerarCracha() //Interfaces explicitas por definição são públicas então precisa  remover o modificador public
        {
            Console.WriteLine("IFuncionario");
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }
        void IPlantonista.GerarCracha() //Interfaces explicitas por definição são públicas então precisa  remover o modificador public
        {

            Console.WriteLine("IPlantonista");
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        public decimal Salario { get; }

        int IFuncionario.CargaHorariaMensal { get; set; } //Interfaces explicitas por definição são públicas então precisa  remover o modificador public
        int IPlantonista.CargaHorariaMensal { get; set; } //Interfaces explicitas por definição são públicas então precisa  remover o modificador public

        public Funcionario(decimal salario)
        {
            Salario = salario;
        }

        public void EfeturarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }
}
