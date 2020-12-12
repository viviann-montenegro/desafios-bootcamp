using System;

namespace desafio3_3
{
    class UltrapassandoV
    {
        static void Main(string[] args)
        {
            int R = Int32.Parse(Console.ReadLine());
            int V = 0;
            int soma = R;
            int aux = R + 1;
            int cont = 1;
            
            while(R >= V)
            {
              V = Int32.Parse(Console.ReadLine());
            }
            
            while(soma <= V)
            {
              soma += aux;
              aux += 1;
              cont += 1;
            }
            
            Console.Write(cont);
        }
    }
}