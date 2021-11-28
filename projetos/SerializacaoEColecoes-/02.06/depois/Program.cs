using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._06
{
    class Program
    {
        static PlacasDeCarro placas = new PlacasDeCarro();

        static void Main(string[] args)
        {
            placas.Add("FND-7714");
            placas.Add("ABC-1234");
            placas.Add("XYZ-9987");
            placas.Add("123-ABCD");

            foreach (var placa in placas)
            {
                Console.WriteLine(placa);
            }

            ///PROBLEMA: CRIAR UMA COLEÇÃO DE PLACAS DE CARRO VÁLIDAS
            ///SOLUÇÃO: CRIAR UMA COLEÇÃO PERSONALIZADA
        }
    }

    class PlacasDeCarro : ICollection<string>
    {
        private List<string> lista = new List<string>();

        public int Count => lista.Count;

        public bool IsReadOnly => false;

        public void Add(string item)
        {
            if (!EhPlacaValida(item))
            {
                throw new ArgumentException("Placa não é válida: " + item);
            }

            lista.Add(item);
        }

        public void Clear()
        {
            lista.Clear();
        }

        public bool Contains(string item)
        {
            return lista.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            lista.CopyTo(array, arrayIndex);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return lista.GetEnumerator();
        }

        public bool Remove(string item)
        {
            return lista.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lista.GetEnumerator();
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
