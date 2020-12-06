using System;

namespace desafio1_2
{
    class Distancia
    {
        static void Main(string[] args)
        {
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
            Console.WriteLine(minutos + " minutos");
        }
    }
}
