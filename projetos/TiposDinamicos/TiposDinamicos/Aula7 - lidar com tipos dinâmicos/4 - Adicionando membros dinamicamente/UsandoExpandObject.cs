using System;
using System.Dynamic;
using Newtonsoft.Json;

namespace certificacao_csharp_roteiro
{
    class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                "\"Para\": \"Guilherme Silveira\"}";

            //Observe que com auxilio de um ExpandoObject é possível definir um dynamic, que aceita inserção de novas propriedades e até métodos

            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);

            mensagem.Texto = $"Olá, {mensagem.Para}!";

            EnviarMensagem(mensagem);

            mensagem.Inverter = new Action(()=>{//Este Action permite criar um método anônimo
                var de = mensagem.De;
                mensagem.De = mensagem.Para;
                mensagem.Para = de;

                mensagem.Texto = $"Olá {mensagem.Para}";

            });

            mensagem.Inverter();
            EnviarMensagem(mensagem);
        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }
}
