using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RastreamentoDeAplicacao
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Este tipo de log aparecerá nos logs de eventos do Windows, não sei se funciona no linux...
            //OBS: RODAR VISUAL STUDIO COMO ADM

            //Também é possível usar o 'TraceSource' para este fim e ele tem customizações a mais...
            var traceListener = new EventLogTraceListener("AplicaçãoDoFilipe");
            Trace.Listeners.Add(traceListener);
            Trace.AutoFlush = true;
            Trace.TraceInformation("A aplicação irá iniciar");


            Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) =>
            {
                Trace.TraceWarning("A aplicação foi finalizada prematuramente no ctrl+C");
            };


            Console.WriteLine(new String('=', 50));
            Console.WriteLine("Iniciando aplicação");

            Console.WriteLine("Processando dados");


            Trace.TraceInformation("A aplicação irá processar os dados");
            await processarDados();
            Trace.TraceInformation("A aplicação já processou os dados");

            Console.WriteLine("Finalizando aplicação");
            Console.WriteLine(new String('=', 50));

            Console.ReadKey();
        }
        

        static async Task processarDados() 
        {
            int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var i = 0.0;
            foreach (var item in lista)
            {
                i++;
                await Task.Delay(500);
                Console.WriteLine($"Porcentagem => {(100.00 / lista.Length) * i}%");
                Trace.TraceInformation($"Porcentagem => {(100.00 / lista.Length) * i}%");
            }
        }
    }
}
