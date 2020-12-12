using System;

namespace desafio3_1
{
    class QuadradoECubo
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            
            int Num = 1;
            int Quad = 1;
            int Cub = 1;
            
            for(int i = 0; i < N; i++)
            {
                Quad = Num * Num;
                Cub = Quad * Num;
                
                Console.WriteLine($"{Num} {Quad} {Cub}");
                
                Num += 1;
            }
        }
    }
}