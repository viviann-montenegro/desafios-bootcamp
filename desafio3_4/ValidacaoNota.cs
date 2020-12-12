using System;

namespace desafio3_4
{
    class ValidacaoNota
    {
        static void Main(string[] args)
        {
            int ContNotaValid = 0;
            double nota = 0;
            double soma = 0;
            double mediaSem = 0;
            
            while (ContNotaValid < 2)
            {
                nota = double.Parse(Console.ReadLine());
              
                if (nota >= 0 && nota <= 10)
                {
                    soma += nota;
                    ContNotaValid += 1;
                }
                else
                {
                  Console.WriteLine("nota invalida");
                }
            }
            
            mediaSem = soma / ContNotaValid;
            Console.WriteLine("media = " + mediaSem.ToString("N2"));
        }
    }
}