
using System;

namespace Atributos
{
    //TAREFA 4: Definir na classe Venda os formatos de impressão detalhada e resumida
    [Serializable]
    [FormatoResumido("{0,-12}  {1,-12}  {2,12:C}  {3,-12:C}")]
    [FormatoDetalhado("{0,-12}  {1,-12}  {2,12:C}  {3,-12:C}  {4,-20:C}  {5,-20:C}  {6,-20:C}  {7,-20:C}")]
    public class Venda
    {
        public string Data;
        public string Produto;
        public int Preco;
        public string TipoPagamento;
        [NonSerialized]
        public string Nome;
        public string Cidade;
        public string Estado;
        public string Pais;
        public string DataCriacao;
        public string UltimoLogin;
        public double Latitude;
        public double Longitude;
    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class FormatoResumidoAttribute : Attribute 
    {
        public string Formato { get; set; }

        public FormatoResumidoAttribute(string formato)
        {
            Formato = formato;
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class FormatoDetalhadoAttribute : Attribute 
    {
        public string Formato { get; set; }

        public FormatoDetalhadoAttribute(string formato)
        {
            Formato = formato;
        }
    }
}
