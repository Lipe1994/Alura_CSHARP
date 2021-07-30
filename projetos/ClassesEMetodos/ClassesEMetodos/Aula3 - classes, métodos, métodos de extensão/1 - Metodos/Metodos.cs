using System;

namespace certificacao_csharp_roteiro
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);
            Retangulo outroRetangulo = new Retangulo(6, 5);

            Console.WriteLine($"Area do retangulo: { retangulo.GetArea()}");

            Console.WriteLine($"Comparando semelhança entre 2 retangulos : {retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura) }");
            
            Console.WriteLine($"Comparando semelhança entre 2 retangulos (Método de sobrecarga): " +
                $"{retangulo.Semelhante(outroRetangulo) }");
            
            Console.WriteLine($"Comparando semelhança entre 2 retangulos (Método de sobrecarga 2): " +
                $"{Retangulo.Semelhante(retangulo, outroRetangulo) }");
           
        }
    }

    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"altura: {altura}, largura: {largura}");
        }

        //Método internal, visível em todo assembly/projeto
        internal double GetArea()
        {
            return Altura * Largura;
        }

        //O método Semelhante, será sobrecarregado =>>
        internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetanguloLargura / outroRetanguloAltura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetanguloLargura / outroRetanguloAltura));
        }
        

        internal bool Semelhante(Retangulo outroRetangulo)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetangulo.Largura / outroRetangulo.Altura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetangulo.Altura / outroRetangulo.Largura));
        }
        
        //Essa sobrecarga aqui deve ser acessada através da classe sem instancia
        internal static bool Semelhante(Retangulo retangulo, Retangulo outroRetangulo)
        {
            return
                ((retangulo.Largura / retangulo.Altura) == /*proporção deste retângulo*/
                (outroRetangulo.Largura / outroRetangulo.Altura)) /*proporção do outro retângulo*/
                ||
                ((retangulo.Altura / retangulo.Largura) == /*compara a proporção inversa*/
                (outroRetangulo.Altura / outroRetangulo.Largura));
        }
    }
}
