using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _02._4.pesquisa
{
    internal class Pesquisa
    {
        private readonly Label lblDocumento;
        private readonly List<string> parametros;
        private int indiceDe;

        public Pesquisa(Label lblDocumento, List<string> parametros)
        {
            this.lblDocumento = lblDocumento;
            this.parametros = parametros;
        }

        internal string ExecutarComando(string tipoComando)
        {
            if (parametros
                .Where(p => string.IsNullOrWhiteSpace(p))
                .Any())
                return "Os parâmetros precisam ser preenchidos";

            switch (tipoComando)
            {
                case "Contem":
                    return Contem();
                case "ComecaCom":
                    return ComecaCom();
                case "TerminaCom":
                    return TerminaCom();
                case "IndiceDe":
                    return IndiceDe();
                case "Trecho":
                    return Trecho();
                case "Substituir":
                    return Substituir();
                default:
                    return string.Empty;
            }
        }

        private string Contem()
        {
            //lblDocumento: caixa de texto do Windows Forms
            var textoBusca = parametros.FirstOrDefault();

            bool contem = lblDocumento.Text
                                .ToLower()
                                .Contains(textoBusca.ToLower());

            if (contem)
            {
                return "O documento CONTÉM a string '" + textoBusca + "'";
            }
            else
            {
                return "O documento NÃO CONTÉM a string '" + textoBusca + "'";
            }
        }

        private string ComecaCom()
        {
            var textoBusca = parametros.FirstOrDefault();

            bool comecaCom = lblDocumento.Text.StartsWith(textoBusca, StringComparison.InvariantCultureIgnoreCase);

            if (comecaCom)
            {
                return "O documento COMEÇA COM a string '" + textoBusca + "'";
            }
            else
            {
                return "O documento NÃO COMEÇA COM a string '" + textoBusca + "'";
            }
        }

        private string TerminaCom()
        {
            var textoBusca = parametros.FirstOrDefault();

            var terminaCom = lblDocumento.Text.EndsWith(textoBusca, StringComparison.InvariantCultureIgnoreCase);

            if (terminaCom)
            {
                return "O documento TERMINA COM a string '" + textoBusca + "'";
            }
            else
            {
                return "O documento NÃO TERMINA COM a string '" + textoBusca + "'";
            }
        }

        private string IndiceDe()
        {
            var textoBusca = parametros.FirstOrDefault();

            indiceDe = lblDocumento.Text.IndexOf(textoBusca);

            if (indiceDe == -1)
            {
                return "String não encontrada: '" + textoBusca + "'";
            }
            else
            {
                return "Índice da string '" + textoBusca + "' é: " + indiceDe;
            }
        }

        private string Trecho()
        {
            int.TryParse(parametros[0], out int indiceInicial);
            int.TryParse(parametros[1], out int comprimento);

            //lblDocumento.SelectionStart = ???
            //lblDocumento.SelectionLength = ???

            string trecho = lblDocumento.Text.Substring(indiceInicial, comprimento);
            
            return "O trecho selecionado é: " + trecho;
        }

        private string Substituir()
        {
            var antigoTexto = parametros[0];
            var novoTexto = parametros[1];

            lblDocumento.Text =
                lblDocumento.Text.Replace(antigoTexto, novoTexto);


            //var indice = lblDocumento.Text.IndexOf(antigoTexto);
            //var inicioTexto = lblDocumento.Text.Substring(0, indice);
            //var finalTexto = lblDocumento.Text.Substring(indice+antigoTexto.Length)
            //lblDocumento.Text =  inicioTexto + novoTexto + finalTexto;

            return "Trecho substituído com sucesso.";
        }
    }
}