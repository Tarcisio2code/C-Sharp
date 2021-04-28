using System;

namespace Desafios1a5
{
    class QuadradoeaoCubo
    {
        static void Main()
        {
            int numLinhas = int.Parse(Console.ReadLine());
            if (numLinhas < 1 || numLinhas > 1000)
                return;

            for ( int i = 1; i <= numLinhas ; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i, 3)}");
            }
        }
    }
}
