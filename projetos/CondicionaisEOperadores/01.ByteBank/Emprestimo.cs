using System;

namespace ByteBank
{

    public delegate void PrazoMaximoEstouradoHandler(object source, EventArgs e);
    public class Emprestimo
    {
        private int prazo;
        private const int PRAZO_MAXIMO_PAGAMENTO_ANOS = 5;
        private const decimal JUROS = 0.034m;

        private string codigoContrato;

        private bool ValidarCodigo(string codigoContrato)
        {
            bool codigoContratoValido = true;
            foreach (var caractere in codigoContrato)
            {
                //só deve ser válido se for numérico ou maiúscula
                bool numerico = Char.IsDigit(caractere);
                bool maiuscula = Char.IsUpper(caractere);

                bool valido = numerico || maiuscula;//Operador condicional OU
                if (!(valido))
                {
                    codigoContratoValido = false;
                    break;
                }
            }

            return codigoContratoValido;
        }

        public Emprestimo(string codigoContrato)
        {
            if (ValidarCodigo(codigoContrato))
            {
                this.codigoContrato = codigoContrato;
                Console.WriteLine($"Novo empréstimo com código: {codigoContrato}");
            }
            else
            {
                //lançar uma exceção
            }
        }

        public event PrazoMaximoEstouradoHandler OnPrazoMaximoEstourado;

        public int Prazo
        {
            get
            {
                return prazo;
            }
            set
            {
                //se o novo prazo for maior que o prazo máximo,
                //lançar um evento de "prazo estourado"
                //senão, definir o novo prazo.

                if (value > PRAZO_MAXIMO_PAGAMENTO_ANOS)//Cláusura de guarda
                {
                    //OnPrazoMaximoEstourado(this, new EventArgs()); qui pode dar  nullException
                    OnPrazoMaximoEstourado?.Invoke(this, new EventArgs());//O Invoke é para garantir que OnPrazoMaximoEstourado não seja null antes de execuar;
                    return;
                }
                prazo = value;
                Console.WriteLine($"novo prazo: {prazo}");
            }
        }

        public decimal CalcularJuros(decimal valor, int prazo)
        {
            decimal valorJuros;
            decimal taxaJuros;

            //1) se o prazo é maior que zero E menor que 5 E
            //o valor é menor que 7 mil, a taxa de juros é 3,5%
            //   1.1) senão, se o prazo for maior que 5 
            //        E o valor for maior que 7 mil, a taxa é 7,5%
            //   1.2) senão, a taxa de juros é 8,75%

            if (prazo > 0 && prazo < 5 && valor < 7000)
            {
                taxaJuros = 0.035m;
            }
            else if (prazo > 5 && valor > 7000)
            {
                taxaJuros = 0.075m;
            }
            else
            {
                taxaJuros = 0.0875m;
            }
            valorJuros = valor * taxaJuros * prazo;
            Console.WriteLine($"valorJuros: {valorJuros}");
            return valorJuros;
        }

        public void Finalizar()
        {
            //REGRAS:
            //=======
            //No modo TRIAL, somente o método AvaliarEmprestimo() deve ser chamado.
            //No modo BASIC, os três métodos devem ser chamados.
            //NO modo ADVANCED, somente os métodos AvaliarEmprestimo() e
            //      ProcessarEmprestimo() devem ser chamados.

/*
 * Essas condicionais(Diretiva de pré compilação IF) são resolvidas durante o build, e os simbolos analizados são definidos nas configurações do projeto
 */

#if TRIAL
            AvaliarEmprestimo();
#elif BASIC
            AvaliarEmprestimo();
            ProcessarEmprestimo();
            FinanciarEmprestimo();
#elif ADVANCED
            AvaliarEmprestimo();
            ProcessarEmprestimo();
#endif


        }

        private void FinanciarEmprestimo()
        {
            Console.WriteLine("FinanciarEmprestimo");
        }

        private void ProcessarEmprestimo()
        {
            Console.WriteLine("ProcessarEmprestimo");
        }

        private void AvaliarEmprestimo()
        {
            Console.WriteLine("AvaliarEmprestimo");
        }
    }

}
