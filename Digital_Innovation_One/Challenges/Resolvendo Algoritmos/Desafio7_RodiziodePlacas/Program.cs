using System;

namespace Desafio7
{
    class RodiziodeCavaloseCarruagens
    {
        static bool ValidaLetras(string Entrada)
        {
            if (Entrada.Length != 3)
               return false;

            foreach (char ch in Entrada)
            {
//                if (char.IsLower(ch) || char.IsNumber(ch) || char.IsPunctuation(ch))
                if (!char.IsLetter(ch) || char.IsLower(ch))
                {
                        return false;
                }
            }
            return true;
        }
        static bool ValidaNumeros(string Entrada)
        {
            if (Entrada.Length != 4)
                return false;

            foreach (char ch in Entrada)
            {
                if (!char.IsNumber(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            string Retorno="FALHA";
            int qtdePlacas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdePlacas; i++)
            {
                string[] placa = Console.ReadLine().Split("-");
                if (placa.Length <= 1 || !ValidaLetras(placa[0]) || !ValidaNumeros(placa[1]))
                {
                    Retorno = "FALHA";
                }
                else
                {
                    int final = int.Parse(placa[1].Substring(placa[1].Length -1));
                    if (final == 1 || final == 2)
                    {
                        Retorno = "SEGUNDA";
                    }
                    else if (final == 3 || final == 4)
                    {
                        Retorno = "TERCA";
                    }
                    else if (final == 5 || final == 6)
                    {
                        Retorno = "QUARTA";
                    }
                    else if (final == 7 || final == 8)
                    {
                        Retorno = "QUINTA";
                    }
                    else if (final == 9 || final == 0)
                    {
                        Retorno = "SEXTA";
                    }
                }
                Console.WriteLine(Retorno);
            }
        }
    }
}

// para estudar...
//using System;

//using System.Text.RegularExpressions;

//class MyClass
//{

//    static void Main(String[] args)
//    {

//        string pattern = @"([A-Z]{3}-[0-9]{4})";

//        int qnt_tests = int.Parse(Console.ReadLine());

//        string[] id_car = new string[qnt_tests];

//        Match m;

//        for (int i = 0; i < qnt_tests; ++i)

//            id_car[i] = Console.ReadLine();



//        for (int i = 0; i < qnt_tests; ++i)
//        {

//            if (id_car[i].Length > 8)
//            {

//                Console.WriteLine("FALHA");

//                continue;

//            }

//            m = Regex.Match(id_car[i], pattern);

//            if (m.Success)
//            {

//                if (id_car[i].EndsWith("1") || id_car[i].EndsWith("2"))

//                    Console.WriteLine("SEGUNDA");

//                if (id_car[i].EndsWith("3") || id_car[i].EndsWith("4"))

//                    Console.WriteLine("TERCA");

//                if (id_car[i].EndsWith("5") || id_car[i].EndsWith("6"))

//                    Console.WriteLine("QUARTA");

//                if (id_car[i].EndsWith("7") || id_car[i].EndsWith("8"))

//                    Console.WriteLine("QUINTA");

//                if (id_car[i].EndsWith("9") || id_car[i].EndsWith("0"))

//                    Console.WriteLine("SEXTA");



//            }
//            else
//            {

//                Console.WriteLine("FALHA");

//            }

//        }

//    }

//}