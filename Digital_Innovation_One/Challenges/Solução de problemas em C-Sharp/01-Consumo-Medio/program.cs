/*
    Desafio
    Você deve calcular o consumo médio de um automóvel
    onde será informada a distância total percorrida (em Km)
    e o total de combustível consumido (em litros).
*/
using System; 

namespace consumo_medio
{
    class Program
    {
        static void Main(string[] args)
        { 
                int distancia;
                double combustivelGasto, consumoMedio;

                distancia = Convert.ToInt32(Console.ReadLine());
                combustivelGasto = Convert.ToDouble(Console.ReadLine());

                consumoMedio =  distancia / combustivelGasto; //atribua a formula para que o codigo funcione corretamente

                Console.WriteLine("{0:0.000} km/l", consumoMedio);
        }
    }
}