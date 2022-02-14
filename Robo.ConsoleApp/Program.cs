using System;

namespace Robo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variaveis
            Console.WriteLine("Informe a areaX:");
            int localizacaoX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a areay:"); //para o usuario conseguir identificar
            int localizacaoy = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Informe a area do robo X:");
            int localizacaoRoboX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a area do robo y:");
            int localizacaoRoboY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o sentido do robo:");
            char sentidoRobo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Informe os movimentos do robo:");
            string movimentos = Console.ReadLine();

            // comandos

            for (int i = 0; i < movimentos.Length; i++) //parte importante do if 
            {
                char comandos = movimentos[i]; //char é um comando 

                    if (comandos == 'E')  
                {
                    if (sentidoRobo == 'N')
                    {
                        sentidoRobo = 'O';
                    }
                    else if (sentidoRobo == 'O')
                    {
                        sentidoRobo = 'S';
                    }
                    else if (sentidoRobo == 'S')
                    {
                        sentidoRobo = 'L';
                    }
                    else if (sentidoRobo == 'L')
                    {
                        sentidoRobo = 'N';
                    }
                }
                if (comandos == 'D')
                {
                    if (sentidoRobo == 'N')
                    {
                        sentidoRobo = 'L';
                    }
                    else if (sentidoRobo == 'L')
                    {
                        sentidoRobo = 'S';
                    }
                    else if (sentidoRobo == 'S')
                    {
                        sentidoRobo = 'O';
                    }
                    else if (sentidoRobo == 'O')
                    {
                        sentidoRobo = 'N';
                    }
                    if (comandos == 'M')
                    {
                        if (sentidoRobo == 'N')
                        {
                            localizacaoRoboY = localizacaoRoboY + 1;
                        }
                        else if (sentidoRobo == 'L')
                        {
                            localizacaoRoboX = localizacaoRoboX + 1;
                        }
                        else if (sentidoRobo == 'S')
                        {
                            localizacaoRoboY = localizacaoRoboY - 1;
                        }
                        else if (sentidoRobo == 'O')
                        {
                            localizacaoRoboX = localizacaoRoboX - 1;
                        }
                    }

                }

            }           Console.WriteLine("A posicao final é:")
          
        }
   }
}