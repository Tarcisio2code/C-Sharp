using System;

namespace _01_Calculo_de_Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmPorHora = 12;
            string[] entrada = Console.ReadLine().Split(" ");
            int horas = int.Parse(entrada[0]);
            int velociade = int.Parse(entrada[1]);
            double distancia = horas * velociade;
            double litros = distancia / kmPorHora;
            Console.WriteLine(Math.Round(litros,3));
        }
    }
}
