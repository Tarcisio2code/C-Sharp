using System;

namespace Desafio2
{
    class CorridadeTartarugas
    {
        static void Main()
        {
            for (int i = 1; i <= 3; i++)
            {
                int numTartarugas = int.Parse(Console.ReadLine());
                int[] Velocidades = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                Array.Sort(Velocidades);
                int Nivel = Velocidades[Velocidades.GetUpperBound(0)];
                if (Nivel > 0 && Nivel < 10)
                {
                    Console.WriteLine("1");
                }
                else if (Nivel >= 10 && Nivel < 20)
                {
                    Console.WriteLine("2");
                }
                else if (Nivel >= 20)
                {
                    Console.WriteLine("3");
                }
            }
        }
    }
}