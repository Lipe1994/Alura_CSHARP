using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RastreamentoDeAplicacao
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var aquivo = $"log_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{(int)DateTime.Now.TimeOfDay.TotalSeconds}.txt";
            //Garantindo que o arquivo de logs exista
            var logStream = new System.IO.FileStream(aquivo, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            logStream.Dispose();//liberando recurso, que com arquivo já criado o TraceListner se vira

            var traceListener = new TextWriterTraceListener(aquivo);
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
            }
        }
    }
}
