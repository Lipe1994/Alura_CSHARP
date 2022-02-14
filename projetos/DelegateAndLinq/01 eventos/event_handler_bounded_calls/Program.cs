using System;
using System.Collections.Generic;
using System.Linq;

namespace event_handler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note que é possível invocar eventos de um mesmo handle separadamente usando a coleção de eventos do método GetInvocationList()

            Campainha campainha = new Campainha();
            campainha.OnCampainhaTocou += CampainhaTocou1;
            campainha.OnCampainhaTocou += CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            campainha.OnCampainhaTocou -= CampainhaTocou1;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            Console.ReadKey();

        }

        static void CampainhaTocou1(object sender, EventArgs args)
        {
            Console.WriteLine("A campainha tocou.(1)");
            throw new Exception("Exceção na campainha 01");
        }
        static void CampainhaTocou2(object sender, EventArgs args)
        {
            Console.WriteLine("A campainha tocou.(2)");
            throw new Exception("Exceção na campainha 02");
        }
    }

    class Campainha
    {
        public event EventHandler OnCampainhaTocou;

        public void Tocar()
        {
            List<Exception> erros = new List<Exception>();

            if (OnCampainhaTocou != null)
            {
                foreach (var invocation in  OnCampainhaTocou.GetInvocationList())
                {
                    try
                    {

                        invocation?.DynamicInvoke(this, new EventArgs());
                    }
                    catch (Exception e) 
                    {
                        erros.Add(e);
                    }
                }
            }

            if (erros.Any()) 
            {
                throw new AggregateException(erros);
            }

        }
    }
}


