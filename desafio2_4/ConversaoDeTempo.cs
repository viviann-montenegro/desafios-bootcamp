using System;

namespace desafio2_4
{
    class ConversaoDeTempo
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var horas = N/3600;
            var minutos = (N%3600)/60;
            var segundos = (N%3600)%60;

            Console.Write($"{horas}:{minutos}:{segundos}");
        }
    }
}
