using System;

namespace desafio2_3
{
    class PizzaAntesdeFdA
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(" ");
            int numAmigos = int.Parse(line[0]);
            int datas = int.Parse(line[1]);

            string dataFinal = "";
            int disponivel = 0;
            bool dataOk = false;

            for (int i = 0; i < datas; i++)
            {
                disponivel = 0;
                string[] dados = Console.ReadLine().Split(" ");
                dataFinal = dados[0];
                for (int j = 1; j < numAmigos + 1; j++)
                {
                    disponivel += int.Parse(dados[j]);
                }
                dataOk = (disponivel == numAmigos);
                if (dataOk)
                {
                    break;
                }
            }

            if (dataOk)
            {
                Console.Write(dataFinal);
            }
            else
            {
                Console.Write("Pizza antes de FdA");
            }
        }
    }
}