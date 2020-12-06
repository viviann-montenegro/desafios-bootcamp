using System;

namespace desafio2_2
{
    class CardapioAereo
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(" ");
            int totalPizza = int.Parse(line1[0]);
            int totalSalada = int.Parse(line1[1]);
            int totalMassa = int.Parse(line1[2]);

            string[] line2 = Console.ReadLine().Split(" ");
            int reqPizza = int.Parse(line2[0]);
            int reqSalada = int.Parse(line2[1]);
            int reqMassa = int.Parse(line2[2]);

            int totalSemRef = 0;

            if(totalPizza < reqPizza)
            {
                totalSemRef += reqPizza - totalPizza;
            }
            if(totalSalada < reqSalada)
            {
                totalSemRef += reqSalada - totalSalada;
            }
            if(totalMassa < reqMassa)
            {
                totalSemRef += reqMassa - totalMassa;
            }

            Console.Write(totalSemRef);

        }
    }
}
