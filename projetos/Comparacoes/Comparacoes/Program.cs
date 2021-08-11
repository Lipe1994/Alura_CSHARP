using System;
using System.Collections.Generic;

namespace Comparacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno2 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };

            Aluno aluno3 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            //Testando as comparações implementadas
            Console
                .WriteLine($"Aluno1 é igual a Aluno2 => Equals: {aluno1.Equals(aluno2)}, operator == { aluno1 == aluno2}, operator != {aluno1 != aluno2}");
 
            Console
                .WriteLine($"Aluno1 é igual a Aluno3 => Equals: {aluno1.Equals(aluno3)}, operator == { aluno1 == aluno3}, operator != {aluno1 != aluno3}");
        
            Console
                .WriteLine($"Aluno2 é igual a Aluno3 => Equals: {aluno2.Equals(aluno3)}, operator == { aluno2 == aluno3}, operator != {aluno2 != aluno3}");
        

            //Usando interface IConparable
            Aluno aluno4 = new Aluno
            {
                Nome = "Debora Ferreira",
                DataNascimento = new DateTime(1996, 1, 1)
            };            
            
            Aluno aluno5 = new Aluno
            {
                Nome = "Debora Sousa",
                DataNascimento = new DateTime(1996, 1, 1)
            };            
            
            Aluno aluno6 = new Aluno
            {
                Nome = "Debora Augusta",
                DataNascimento = new DateTime(1996, 1, 1)
            };

            List<Aluno> alunos = new List<Aluno>{
                aluno1,
                aluno2,
                aluno3,
                aluno4,
                aluno5,
                aluno6
            };

            alunos.Sort();//*

            /*
                Note que após aplicar método sort(), a lista se ordenou de acordo com IComparable
            */
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);   
            }

        }
    }

    public class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data nascimento: {DataNascimento:dd/MM/yyyy}";
        }

        public override bool Equals(object obj)//Esta é a maneira de tratar o equals do objeto
        {
            if(obj is Aluno aluno)
            {
                return aluno.Nome == this.Nome &&  aluno.DataNascimento.Equals(this.DataNascimento);
            }

            return false;
        }

        public static bool operator ==(Aluno a, Aluno b)//Esta é a maneira de tratar o operador '==' do objeto
        {
            // if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            //     return true;
            // if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            //     return true;

            return a.Equals(b);
        }

        public static bool operator != (Aluno aluno, Aluno b)//Esta é a maneira de tratar o operador '!=' do objeto
        {
            return !(aluno == b);
        }


        public override int GetHashCode()//Este hash ajuda o C# a lidar com listas
        {
            return HashCode.Combine(Nome, DataNascimento);
        }

        /*
        Este método é utilizado em listas, quando usado ordenação (Sort())
        */
        public int CompareTo(object obj)
        {
            // 0 => igual
            // < 0 => anterior, menor
            // > 0 => proximo, maior

            if(obj == null)
            {
                return 1;
            }

            var outro = obj as Aluno;

            if(outro == null){
                throw new ArgumentException($"Item não é um aluno");
            }

            var index = this.DataNascimento.CompareTo(outro.DataNascimento);
            
            if(index == 0)
            {
                return this.Nome.CompareTo(outro.Nome);
            }

            return index;
        }
    }
}
