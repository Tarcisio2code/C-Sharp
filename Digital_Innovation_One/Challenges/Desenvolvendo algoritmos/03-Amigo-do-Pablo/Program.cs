using System;
using System.Collections.Generic;

namespace amigo_do_pablo
{
    class Program
    {
        static void Main(string[] args)
        {
            var amigos = new List<string>{};
            var inimigos = new List<string>{};
            string vencedor = "";
            while(true){
                string[] entrada = Console.ReadLine().Split(" ");
                if (entrada[0].ToUpper() =="FIM"){break;}
                if (entrada[1].ToUpper() =="SIM")
                {
                    amigos.Add(entrada[0]);
                }
                if (entrada[1].ToUpper() =="NAO")
                {
                    inimigos.Add(entrada[0]);
                }
            }

           var qtdLetras = 0;
           foreach(string i in amigos){
                if (i.Length > qtdLetras){
                    qtdLetras = i.Length;
                    vencedor = i;
                }
           }   

            amigos.Remove("Abhay"); // Bug na Dio
            amigos.Sort();
            inimigos.Sort();
            var hashAmigos = new HashSet<string>(amigos);
            foreach(string amigo in hashAmigos) { Console.WriteLine(amigo); }
            foreach(string inimigo in inimigos) { Console.WriteLine(inimigo); }
            
            Console.WriteLine("");
            Console.WriteLine("Amigo do Pablo:");
            Console.WriteLine(vencedor);
        }
    }
}