using System;

namespace desafio2_5
{
    class IdadeEmDias
    {
        static void Main(string[] args)
        {
            var idade = int.Parse(Console.ReadLine());

            var anos = idade/365;
            var meses = (idade%365)/30;
            var dias = (idade%365)%30;

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}
