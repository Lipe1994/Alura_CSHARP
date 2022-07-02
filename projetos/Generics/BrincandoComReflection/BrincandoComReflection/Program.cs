using BrincandoComReflection.Modelo;
using System;
using System.Reflection;

namespace BrincandoComReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarefa 1: obter o nome completo do assembly atual
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine($"Nome do assembly: {assembly.FullName}");

            //Tarefa 2: obter a versão do assembly atual
            //Obter a identidade do assembly primeiro!
            var identidadeAssembly = assembly.GetName();
            Console.WriteLine($"Versão: {identidadeAssembly.Version}");
            Console.WriteLine($"Versão Major: {identidadeAssembly.Version.Major}");
            Console.WriteLine($"Versão Minor: {identidadeAssembly.Version.Minor}");


            //Tarefa 3: descobrir se o assembly atual 
            //          está no Global Assembly Cache
            Console.WriteLine($"Está no global assembly cache? {assembly.GlobalAssemblyCache}");


            //Tarefa 4: descobrir todos os módulos, 
            //          tipos e membros do assembly
            foreach(var module in assembly.GetModules()) 
            {
                Console.WriteLine($"Módulo: {module}");
                foreach (var type in module.GetTypes()) 
                {
                    Console.WriteLine($"\t Tipo: {type}");
                    foreach (var membro in type.GetMembers())
                    {
                        Console.WriteLine($"\t\t membro: {membro}");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //TAREFA 1: obter as propriedades de CarrinhoCliente
            //TAREFA 2: descobrir se podem ler ou escrever
            //TAREFA 3: descobrir seus acessadores getters e setters
            var typeCarrinho = typeof(CarrinhoCliente);

            foreach (var propert in typeCarrinho.GetProperties()) 
            {
                Console.WriteLine();
                Console.WriteLine($"Propert: {propert}, Pode ler? {propert.CanRead} {propert.GetMethod}, Pode escrever? {propert.CanWrite} {propert.SetMethod}");
            }
        }
    }
}
