using System;
using System.Linq;

namespace Desafio3
{
    class Pizza_FdA
    {
        static void Main()
        {
            string[] entrada1 = Console.ReadLine().Split(" ");
            int totalPessoas = int.Parse(entrada1[0]);
            int totalDatas = int.Parse(entrada1[1]);
            if (totalPessoas < 1 || totalDatas > 50)
            {
                return;
            }
            for (int i = 1; i <= totalDatas; i++)
            {
                string[] entrada2 = Console.ReadLine().Split(" ");
                int contador = 0;
                for (int n = 1; n <= totalPessoas; n++)
                {
                    contador += int.Parse(entrada2[n]);
                }
                if (contador == totalPessoas)
                {
                   Console.WriteLine(entrada2[0]);
                   i = totalDatas;
                }
                else if (i == totalDatas)
                {
                    Console.WriteLine("Pizza antes de FdA");
                }
            }
        }
    }
}
