using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio5
{
    class QuantasJoias
    {
        static void Main()
        {
            string joia;
            List<string> listaDeJoias = new List<string>();
            while (!string.IsNullOrWhiteSpace(joia = Console.ReadLine()))
            {
                if (listaDeJoias.Count() == 106)
                    break;
                listaDeJoias.Add(joia);
            }
            string[] joiasDistintas = listaDeJoias.Distinct().ToArray();
            Console.WriteLine(joiasDistintas.Length);
        }
    }
}
