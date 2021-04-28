using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numeroDeFigurinhas = int.Parse(Console.ReadLine());
        int numeroDeFigurinhasCompradas = int.Parse(Console.ReadLine());
        int totalDeFigurinhas = 0;

        int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];

        for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
        {
            int Figurinha = int.Parse(Console.ReadLine());
            if (Figurinha >= 1 && Figurinha <= numeroDeFigurinhas)
            {
                albumDeFigurinha[i] = Figurinha;
            }
        }

        var albumHashSet = new HashSet<int>(albumDeFigurinha);
 
        totalDeFigurinhas = numeroDeFigurinhas - albumHashSet.Count;

        Console.Write(totalDeFigurinhas);
    }
}