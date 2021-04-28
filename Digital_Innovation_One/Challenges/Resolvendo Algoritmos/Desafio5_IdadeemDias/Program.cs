using System;

namespace Desafio5
{
    class IdadeemDias
    {
        static void Main()
        {
            var Entrada = int.Parse(Console.ReadLine());
            int anos = Entrada / 365, meses = Entrada % 365 / 30, dias = Entrada % 365 % 30;
            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
        }
    }
}