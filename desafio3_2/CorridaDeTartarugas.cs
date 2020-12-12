using System;

namespace desafio3_2
{
    class CorridaDeTartarugas 
    {
        static void Main() 
        {
            string[] maiorNvlVel = new string[3];
            for (int i = 0; i < 3; i++)
            {
                string QtdTartaruga = Console.ReadLine();
                string NvlVelocidade = Console.ReadLine();
                if(Nvl3(QtdTartaruga, NvlVelocidade) == true)
                {
                    maiorNvlVel[i] = "3";
                }
                else if(Nvl2(QtdTartaruga, NvlVelocidade) == true)
                {
                    maiorNvlVel[i] = "2";
                }
                else 
                {
                    maiorNvlVel[i] = "1";                
                }
            }
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(maiorNvlVel[j]);
            }
        }

        public static bool Nvl2(string QtdTartaruga, string NvlVelocidade)
        {
            int t = Convert.ToInt32(QtdTartaruga);
            string[] v = NvlVelocidade.Split(" ");
            for (int i = 0; i < t; i++)
            {
                if (int.Parse(v[i]) >= 10)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Nvl3(string QtdTartaruga, string NvlVelocidade)
        {
            int t = Convert.ToInt32(QtdTartaruga);
            string[] v = NvlVelocidade.Split(" ");
            for (int i = 0; i < t; i++)
            {
                if (int.Parse(v[i]) >= 20)
                {
                    return true;
                }
            }
                return false;
        }
    }
}