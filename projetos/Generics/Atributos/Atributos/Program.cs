#define RELATORIO_RESUMIDO
#define RELATORIO_DETALHADO

using System;
using System.Linq;
using System.Reflection;

namespace Atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Relatorio relatorio = new Relatorio("Relatório de Vendas");

            //Imprimir relatório detalhado OU resumido de acordo com a compilação

            Imprimir(relatorio);

            //Verificar se a classe Venda define o atributo [Serializable]

            if (Attribute.IsDefined(typeof(Venda), typeof(SerializableAttribute))) 
            {
                Console.WriteLine("A classe venda define o atributo SerializableAttribute");
            }
            else 
            {
                Console.WriteLine("A classe venda não define o atributo SerializableAttribute");
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("OBTENDO O TIPO DO RELATÓRIO");
            Console.WriteLine("===========================");
            Type type = relatorio.GetType();
            Console.WriteLine(type);

            Console.WriteLine();
            Console.WriteLine("OBTENDO OS MEMBROS DO RELATÓRIO");
            Console.WriteLine("===============================");
            var members = type.GetMembers();
            foreach (var member in members) 
            {
                Console.WriteLine(member);
            }


            Console.WriteLine();
            Console.WriteLine("MODIFICANDO NOME VIA REFLECTION");
            Console.WriteLine("===============================");
            MethodInfo setNome = type.GetMethod("set_Nome");
            setNome.Invoke(relatorio, new object[] { ">>>Novo nome para relatório<<<" });
            Imprimir(relatorio);


            Console.WriteLine();
            Console.WriteLine("TIPOS DO ASSEMBLY");
            Console.WriteLine("QUE IMPLEMENTAM A INTERFACE IRelatorio");
            Console.WriteLine("======================================");
            Assembly asm = Assembly.GetExecutingAssembly();
            foreach (var t in asm.GetTypes()) 
            {
                if (t.IsInterface) 
                {
                    continue;
                }

                if (typeof(IRelatorio).IsAssignableFrom(t))
                {
                    Console.WriteLine(t);
                }
            }



            Console.WriteLine();
            Console.WriteLine("USANDO LINQ PARA VER TIPOS DO ASSEMBLY");
            Console.WriteLine("QUE IMPLEMENTAM A INTERFACE IRelatorio");
            Console.WriteLine("======================================");
            var consulta = from t in asm.GetTypes()
                           where typeof(IRelatorio).IsAssignableFrom(t) && !t.IsInterface select t;

            foreach( var t in consulta)
            {
                Console.WriteLine(t);
            }

            Console.ReadLine();
        }

        static void Imprimir(IRelatorio relatorio) 
        {
            relatorio.Cabecalho();
#if (RELATORIO_RESUMIDO)
            relatorio.ListagemResumida();
#elif (RELATORIO_DETALHADO)
    relatorio.ListagemDetalhada();
#endif
        }
    }
}
