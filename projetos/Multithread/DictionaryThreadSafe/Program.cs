using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace DictionaryThreadSafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMERO_ITENS = 30;
            ConcurrentDictionary<int, int> dicionario = new ConcurrentDictionary<int, int>();//Dicionario com thread safe

            Console.WriteLine("Iniciando dicionário...");

            for (int i =0; i<NUMERO_ITENS; i++) 
            {
                dicionario[i] = 0;
            }

            Thread thread1 = new Thread(() => {
                for(int i =0; i<NUMERO_ITENS; i++)
                {
                    int newValue;
                    do {
                        newValue = dicionario[i] + 1;
                    } while (!dicionario.TryUpdate(i, newValue, dicionario[i]));//Garante que em situação de concorrencia, tryUpdate tentará atualizar o valor apontado até conseguir
                    Thread.Sleep(i*50);
                }

            });
            thread1.Start();


            Thread thread2 = new Thread(() => {
                for (int i = 0; i < NUMERO_ITENS; i++)
                {
                    int newValue;
                    do
                    {
                        newValue = dicionario[i] + 1;
                    } while (!dicionario.TryUpdate(i, newValue, dicionario[i]));
                    Thread.Sleep(i * 50);
                }
            });
            
            thread2.Start();

            thread1.Join();
            thread2.Join();

            ImprimirItens(dicionario);

            Console.WriteLine("Tecle [ENTER] para continuar");
            Console.ReadLine();

        }

        private static void ImprimirItens(IDictionary<int, int> cd)
        {
            for (int i = 0; i < cd.Count; i++)
            {
                Console.WriteLine("dicionario[{0}] = {1}", i, cd[i]);
            }
        }
    }
}
