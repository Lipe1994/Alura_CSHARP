using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

namespace UsandoCodeDOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TAREFA: Utilizar código C# para gerar código C#,
            //          produzindo a classe Funcionario:

            //para mais informações,
            //https://docs.microsoft.com/pt-br/dotnet/framework/reflection-and-codedom/using-the-codedom

            /*
            namespace RecursosHumanos
            {
                using system;
                public class Funcionario
                {
                    public string nome;
                    public decimal salario;
                    public Funcionario(string nome, decimal salario)
                    {
                    }
                }
            }
            */

            //Tarefa 1: criar uma unidade de compilação
            CodeCompileUnit compileUnit = new CodeCompileUnit();

            //Tarefa 2: criar o namespace RecursosHumanos
            CodeNamespace codeNamespace = new CodeNamespace("RecursosHumanos");

            //Tarefa 2.1: importar o namespace System
            CodeNamespaceImport codeNamespaceImport = new CodeNamespaceImport("System");
            codeNamespace.Imports.Add(codeNamespaceImport);


            //Tarefa 2.2: criar a classe Funcionario
            CodeTypeDeclaration codeTypeDeclaration = new CodeTypeDeclaration("Funcionario");

            //Tarefa 2.3: criar o campo nome
            CodeMemberField codeMemberFieldNome = new CodeMemberField(typeof(string), "nome");
            codeMemberFieldNome.Attributes = MemberAttributes.Public;
            codeTypeDeclaration.Members.Add(codeMemberFieldNome);

            //Adiconei um property a mais
            CodeMemberProperty codeMemberProperty = new CodeMemberProperty();
            codeMemberProperty.Name = "Idade";
            codeMemberProperty.Attributes = MemberAttributes.Public;

            codeTypeDeclaration.Members.Add(codeMemberProperty);

            //Tarefa 2.4: criar o campo salário
            CodeMemberField codeMemberFieldSalario = new CodeMemberField(typeof(decimal), "salario");
            codeMemberFieldSalario.Attributes = MemberAttributes.Public;
            codeTypeDeclaration.Members.Add(codeMemberFieldSalario);


            //Tarefa 2.5: criar o construtor da classe
            CodeConstructor codeConstructor = new CodeConstructor();
            codeConstructor.Attributes = MemberAttributes.Public;

            CodeParameterDeclarationExpression paramNome = new CodeParameterDeclarationExpression(typeof(string), "nome");
            codeConstructor.Parameters.Add(paramNome);

            CodeParameterDeclarationExpression paramSalario = new CodeParameterDeclarationExpression(typeof(decimal), "salario");
            codeConstructor.Parameters.Add(paramSalario);

            codeTypeDeclaration.Members.Add(codeConstructor);
            codeNamespace.Types.Add(codeTypeDeclaration);
            
            compileUnit.Namespaces.Add(codeNamespace);


            //Tarefa 3: cria o provedor de modelo de código
            CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");

            using(var streamWritter  = new StreamWriter("Funcionario.cs")) 
            {
                Console.WriteLine("Gerando classe, confira dentro dos arquivos de debug...");
                codeDomProvider.GenerateCodeFromCompileUnit(compileUnit, streamWritter, new CodeGeneratorOptions());
            }

        }
    }
}
