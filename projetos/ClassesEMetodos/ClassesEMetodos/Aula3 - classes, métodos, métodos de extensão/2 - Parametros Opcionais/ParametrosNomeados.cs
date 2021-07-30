using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            //Preenchendo método com parametros ordenados
            ImprimirDetalhesDoPedido("Filipe", 2, "Caneca vermelha");

            //Preenchendo método com parametros nomeados
            ImprimirDetalhesDoPedido(numeroPedido: 2, nomeProduto: "Caneca vermelha", vendedor: "Filipe");

            //Preenchendo método com parametro ordenado e parametros nomeados
            ImprimirDetalhesDoPedido("Filipe", nomeProduto: "Caneca vermelha", numeroPedido: 2);

        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrWhiteSpace(vendedor))
            {
                throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio.", paramName: nameof(vendedor));
            }

            Console.WriteLine($"Vendedor: {vendedor}, Pedido No.: {numeroPedido}, Produto: {nomeProduto}");
        }
    }
}
