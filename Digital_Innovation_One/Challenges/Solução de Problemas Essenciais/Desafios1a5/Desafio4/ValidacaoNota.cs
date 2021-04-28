using System;

namespace Desafio4
{
    class ValidacaodeNota
    {
        static void Main()
        {
            int contador = 0;
            double media, somaNotas = 0;
            while (contador < 2)
            {
                double nota = double.Parse(Console.ReadLine());
                if (nota > 0 && nota <= 10)
                {
                    somaNotas += nota;
                    contador++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            media = (somaNotas / 2);
            Console.WriteLine("media = " + media.ToString("N2"));
        }
    }
}