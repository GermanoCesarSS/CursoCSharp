using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class PrimeiroPrograma
    {
        public static void Executar()
        {
            int M = int.Parse(Console.ReadLine()); // linha
            int N = int.Parse(Console.ReadLine()); // cocuna

            int[,] matriz = new int[M, N];
            for (int i = 0; i < M; i++) // linha
            {
                String[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) //coluna
                {
                    matriz[i, j] = int.Parse(vet[j]);
               
                }
            }

            Console.WriteLine("Valores negativos: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }

        }
    }
}
