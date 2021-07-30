using System;

namespace certificacao_csharp_roteiro
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {

            var cliente1 = new ClienteEspecial("Filipe");
            var cliente2 = new ClienteEspecial();

            cliente1.FazerPedido(0);
            cliente2.FazerPedido(endereco: "Comercial", produtoId: 1, quantidade: 2);

        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome="Anônimo")
        {
            this.nome = nome;
        }


        //Parametros opcionais devem ser colocando sempre após os parametros ordenados
        public void FazerPedido(int produtoId, string endereco="Residêncial", int quantidade=1)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}
