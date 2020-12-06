using System;

namespace desafio2_1
{
    class HoraDaCorrida
    {
        static void Main(string[] args)
        {
            string[] texto = Console.ReadLine().Split(" ");
            int laps = int.Parse(texto[0]);
            int signs = int.Parse(texto[1]);

            int total = laps * signs;

            for (int i = 10; i <= 90; i += 10)
            {
                double result = (double)total / 100 * i;
                Console.Write(Math.Ceiling(result) + " ");
            }
        }
    }
}
