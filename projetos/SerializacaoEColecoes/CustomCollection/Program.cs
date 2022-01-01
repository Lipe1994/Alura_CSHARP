using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Custom list
            Placas placas = new Placas();

            //adicionando
            placas.Add("ABC-1234");
            placas.Add("BCV-7897");
            placas.Add("RTY-9632");
            placas.Add("ASD-1478");

            placas.Imprimir();

            //adicionando placa fora do padrão
            // placas.Add("AS1478");
        }


    }

    class Placas : ICollection<string>
    {
        IList<string> lista = new List<string>();
        public int Count => lista.Count;

        public bool IsReadOnly => false;

        public void Imprimir()
        {
            Console.WriteLine($"\r\n{string.Join(",\r\n", lista)}\r\n");
        }

        public void Add(string item)
        {
            var regex = new Regex(@"[A-Z]{3}\-[0-9]{4}");
            if (!regex.IsMatch(item))
            {
                throw new ArgumentException(item);
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
    }
}
