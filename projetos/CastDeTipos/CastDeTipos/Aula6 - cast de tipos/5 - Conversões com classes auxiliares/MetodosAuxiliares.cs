using System;

namespace certificacao_csharp_roteiro
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            //Conversões com números

            //Conversão que o dev garante o valor digitado
            var valorDigitado = "123";
            int valorInteiro = int.Parse(valorDigitado);
            Console.WriteLine($"valorInteiro => {valorInteiro}\r\n");

            //Conversão que o dev tem como planejar um valor default em poucas linhas
            int.TryParse(valorDigitado, out int valorInteiro2);//Note que instanciei uma variável, valor default é 0, caso valorDigitado não seja um número
            Console.WriteLine($"valorInteiro2 => {valorInteiro2}\r\n");

            //dinheiro
            string valorDigitadoDinheiro = "R$ 10,20"; 
            decimal.TryParse(
                valorDigitadoDinheiro, 
                System.Globalization.NumberStyles.Currency, 
                System.Globalization.CultureInfo.CurrentCulture,
                out decimal dinheiroConvertido);
            Console.WriteLine($"dinheiroConvertido => {dinheiroConvertido}\r\n");

        }
    }
}
