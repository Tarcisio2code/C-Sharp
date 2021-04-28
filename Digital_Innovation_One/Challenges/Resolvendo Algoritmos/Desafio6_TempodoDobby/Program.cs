using System;

namespace Desafio6
{
    class TempodoDobby
    {
        static void Main()
        {
            int minutosRestantes = int.Parse(Console.ReadLine());
            string[] minutosNecessarios = Console.ReadLine().Split(" ");
            int tempo1 = int.Parse(minutosNecessarios[0]), tempo2 = int.Parse(minutosNecessarios[1]);
            int tempoTotal = tempo1 + tempo2;
            if (tempoTotal <= minutosRestantes)
            {
                Console.Write("Farei hoje!");
            }
            else
            {
                Console.Write("Deixa para amanha!");
            }
        }
    }
}
