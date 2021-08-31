using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._06
{
    class Program
    {
        static List<string> placas = new List<string>();

        static void Main(string[] args)
        {
            placas.Add("FND-7714");
            placas.Add("ABC-1234");
            placas.Add("XYZ-9987");

            foreach (var placa in placas)
            {
                Console.WriteLine(placa);
            }

            ///PROBLEMA: CRIAR UMA COLEÇÃO DE PLACAS DE CARRO VÁLIDAS
            ///SOLUÇÃO: CRIAR UMA COLEÇÃO PERSONALIZADA
        }

        static bool EhPlacaValida(string value)
        {
            Regex regex = new Regex(@"^[A-Z]{3}\-\d{4}$");

            if (regex.IsMatch(value))
            {
                return true;
            }

            return false;
        }

    }
}
