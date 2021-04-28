using System;

namespace Desafio1
{
    class Hora_Da_Corrida
    {
        static void Main()
        {
            string[] entrada = Console.ReadLine().Split(" ");
            int numVoltas = int.Parse(entrada[0]);
            int numPlacas = int.Parse(entrada[1]);

            //            int numToltal_Placas = numVoltas * numPlacas;
           double numToltal_Placas = numVoltas * numPlacas;

            for (int i = 10; i <= 90; i += 10)
            {
                double saida = Math.Ceiling((numToltal_Placas * i) / 100);
                Console.Write(saida + " ");
            }
        }
    }
}