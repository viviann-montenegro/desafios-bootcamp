using System;

namespace desafio2_6
{
    class TempoDoDobby
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split();
            var A = int.Parse(line[0]);
            var B = int.Parse(line[1]);

            if(N >= (A+B))
            {
                Console.Write("Farei hoje!");
            } 
            else 
            {
                Console.Write("Deixa para amanha!");
            }
        }
    }
}
