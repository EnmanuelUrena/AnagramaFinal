using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrama_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static bool verificarAnagrama(string cadena1, string cadena2)
        {
            bool esAnagrama = true;
            if (cadena1 == "" || cadena2 == "")
            {
                throw new ArgumentNullException();
            }
            var lista = new List<char>();
            var lista2 = new List<char>();

            lista = cadena1.ToList();
            lista2 = cadena2.ToList();
            lista.Sort();
            lista2.Sort();

            for (int i = 0; i < cadena1.Length; i++)
            {
                if (lista[i] == lista2[i])
                {
                    continue;
                }
                else
                {
                    esAnagrama = false;
                }
            }
            return esAnagrama;
        }
    }
}
