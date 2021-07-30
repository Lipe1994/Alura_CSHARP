using System;

namespace certificacao_csharp_roteiro
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Este é\r\no meu documento :D");
            impressora.ImprimirDocumento();

            impressora.ImprimirHTML();
        }
    }

    public class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }
    }

    //Extension Metod
    public static class ImpressoraExtensions
    {
        public static void ImprimirHTML(this Impressora impressora) 
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    } 
}


