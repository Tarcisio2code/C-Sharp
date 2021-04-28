using System;

namespace Desafio4
{
    class ConversaodeTempo
    {
        static void Main()
        {
            int Entrada = int.Parse(Console.ReadLine());
            int Horas = Entrada / 3600, Minutos = Entrada % 3600 / 60, Segundos = Entrada % 60;
            Console.Write(Horas + ":" + Minutos + ":" + Segundos);

            //TimeSpan tempo = TimeSpan.FromSeconds(Entrada); 
            //int horas = tempo.Hours, minutos = tempo.Minutes, segundos = tempo.Seconds; // A hora retorna errada !
            //Console.Write(horas + ":" + minutos + ":" + segundos);
        }
    }
}
