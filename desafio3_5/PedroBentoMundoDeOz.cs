using System;
using System.Collections.Generic;
using System.Linq;

namespace desafio3_5
{
    class PedroBentoMundoDeOz
    {
        static void Main(string[] args) 
        {
            var joiasTotais = new List<string>();
            while(true)
            {
                string joia = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(joia))
                {
                    joiasTotais.Add(joia);
                }
                else
                {
                    break;
                }
            }
            var joiasUnicas = joiasTotais.Distinct().ToList();
            Console.WriteLine(joiasUnicas.Count);
        }
    }
}