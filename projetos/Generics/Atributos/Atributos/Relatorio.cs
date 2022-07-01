using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Atributos
{
    interface IRelatorio
    {
        string Nome { get; set; }
        void Cabecalho();
        void ListagemDetalhada();
        void ListagemResumida();
    }

    class Relatorio : IRelatorio
    {
        public string Nome { get; set; }
        readonly IList<Venda> vendas;

        public Relatorio(string nome)
        {
            this.Nome = nome;
            vendas = JsonConvert.DeserializeObject<List<Venda>>(File.ReadAllText("Vendas.json"));
        }

        public void Cabecalho()
        {
            Console.WriteLine(this.Nome);
            Console.WriteLine("=============================");
        }

        public void ListagemDetalhada()
        {
            Console.WriteLine("Data          Produto         Preco       TipoPagamento Nome                  Cidade                Região                Pais");
            Console.WriteLine("==========================================================================================================================================");

            //TAREFA 4: Definir na classe Venda os formatos de impressão detalhada e resumida
            var attribute = Attribute.GetCustomAttribute(typeof(Venda), typeof(FormatoDetalhadoAttribute));
            var formatoDetalhado = (FormatoDetalhadoAttribute)attribute;

            foreach (var venda in vendas)
            {
                Console.WriteLine(formatoDetalhado.Formato
                            , venda.Data, venda.Produto, venda.Preco, venda.TipoPagamento, venda.Nome, venda.Cidade, venda.Estado, venda.Pais);
            }
            Console.WriteLine();
        }

        public void ListagemResumida()
        {
            Console.WriteLine("Data          Produto         Preco       TipoPagamento   ");
            Console.WriteLine("==========================================================");


            //TAREFA 4: Definir na classe Venda os formatos de impressão detalhada e resumida
            var attribute = Attribute.GetCustomAttribute(typeof(Venda), typeof(FormatoResumidoAttribute));
            var formatoResumido = (FormatoResumidoAttribute)attribute;


            foreach (var venda in vendas)
            {
                Console.WriteLine(formatoResumido.Formato
                    , venda.Data, venda.Produto, venda.Preco, venda.TipoPagamento);
            }
            Console.WriteLine();
        }
    }
}
