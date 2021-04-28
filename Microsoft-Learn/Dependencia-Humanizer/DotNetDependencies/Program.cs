/* 
    Utilizando a dependência Humanizer para manipulação e exibição de dados

    Retorno
        Quantities:
        0 cases
        1 case
        5 cases

        Date/Time Manipulation:
        ontem
        2 horas atrás
        1 dia        
        2 semanas
*/
using System;
using Humanizer;

namespace DotNetDependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantities:");
            HumanizeQuantities();

            Console.WriteLine("\nDate/Time Manipulation:");
            HumanizeDates();
        }
        
        static void HumanizeQuantities()
        {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }
        static void HumanizeDates()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }
    }
}
