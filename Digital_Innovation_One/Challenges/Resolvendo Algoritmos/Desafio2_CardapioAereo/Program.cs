using System;

namespace Desafio2
{
    class Cardapio_Aereo
    {
        static void Main()
        {
            string[] entrada1 = Console.ReadLine().Split(" ");
            string[] entrada2 = Console.ReadLine().Split(" ");
            int naoRecebem = 0;
            if (int.Parse(entrada1[0]) >=0 && int.Parse(entrada1[2]) <=100 && int.Parse(entrada2[0]) >= 0 && int.Parse(entrada2[2]) <= 100)
            {
                for (int i = 0; i < entrada1.Length; i++)
                {
                    int qtdeItens = int.Parse(entrada1[i]), qtdePassageiros = int.Parse(entrada2[i]);
                    if (qtdePassageiros > qtdeItens)
                    {
                        naoRecebem += qtdePassageiros - qtdeItens;
                    }
                }
                Console.Write(naoRecebem);
            }
        }
    }
}
