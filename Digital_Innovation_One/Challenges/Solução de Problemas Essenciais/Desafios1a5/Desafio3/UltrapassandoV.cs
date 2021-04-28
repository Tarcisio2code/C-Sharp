using System;

namespace Desafio3
{
    class UltrapassandoV
    {
        static void Main()
        {
            int V = 0, y, x;
            int R = int.Parse(Console.ReadLine());
            if (R == 0) return;
            while (V <= R)
            {
                V = int.Parse(Console.ReadLine());
            }
            y = R;
            for (x = 1; y <= V; x++)
            {
                y += R + x;
            }
            Console.Write(x);
        }
    }
}
