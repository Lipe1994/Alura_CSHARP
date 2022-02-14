using System;

namespace action
{
    class Program
    {
        static void Main(string[] args)
        {

            //Func é um tipo nativo, encapsula um método para um delegate
            Func<int, int, int> sum1 = (a, b) => a + b;

            var resultSum = sum1?.Invoke(5,5);
            Console.WriteLine($"[sum1] a + b = {resultSum}");

            //Action também é um tipo nativo, que encasula método para delegate  e sem retorno
            Action<int, int> sum2 = (a, b) => Console.WriteLine($"[sum2] a + b = {a+b}");

            sum2?.Invoke(5,5);


            //Mais sobre Labda
            Console.WriteLine("\r\n");
            Console.WriteLine("Mais sobre Labda");


            Func<int, bool> EhDivisivelPor3 = (num) => num % 3 == 0; /* é relativo a isso abaixo */
            Predicate<int> EhDivisivelPor3P = (num)=> num % 3 == 0;


            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            foreach(var numero in numeros) 
            {
                //if (EhDivisivelPor3(numero) )
                //{
                //    Console.WriteLine(numero);
                //}

                if (EhDivisivelPor3P(numero))
                {
                    Console.WriteLine(numero);
                }
            }

            Console.WriteLine("\r\n usando Array");

            var numerosMultiplosDe3 = Array.FindAll(numeros, EhDivisivelPor3P);
            foreach (var numero in numerosMultiplosDe3)
            {
                    Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
