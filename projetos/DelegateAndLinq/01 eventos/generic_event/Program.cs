using System;

namespace event_handler_generic_argument
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;

            Campainha campainha = new Campainha();
            campainha.OnCampainhaTocou += CampainhaTocou1;
            campainha.OnCampainhaTocou += CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar(++i);

            campainha.OnCampainhaTocou -= CampainhaTocou1;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar(++i);

            Console.ReadKey();

        }

        static void CampainhaTocou1(object sender, CampainhaArgs args)
        {
            Console.WriteLine($"A campainha tocou.(1) {args.Name}");
        }
        static void CampainhaTocou2(object sender, CampainhaArgs args)
        {
            Console.WriteLine($"A campainha tocou.(2) {args.Name}");
        }
    }

    class Campainha
    {
        public event EventHandler<CampainhaArgs> OnCampainhaTocou;

        public void Tocar(int value)
        {
            if (OnCampainhaTocou != null)
            {
                foreach (var invocation in OnCampainhaTocou.GetInvocationList()) { 
                
                    invocation?.DynamicInvoke(this, new CampainhaArgs(name: $"Teste: {value}"));
                }
            }

        }

    }

    class CampainhaArgs : EventArgs 
    {
        public string Name { get; set; }

        public CampainhaArgs() { }
        public CampainhaArgs(string name) {
            Name = name;
        }

    }
}


