using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Tic_Tac_Toe
    {
        public static int PopularMatriz(string[,] matriz, int posicao, List<string> casasJogadas)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = posicao.ToString();
                    casasJogadas.Add(posicao.ToString());
                    posicao++;
                }
                Console.WriteLine();
            }

            return posicao;
        }

        public static void MostrarMatriz(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($" [ {matriz[i, j]} ]");
                }
                Console.WriteLine();
            }
        }

        public static void SubstituirCasa(string[,] matriz, string turno, List<string> casasJogadas, string jogada)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == jogada && casasJogadas.Contains(jogada))
                    {
                        matriz[i, j] = turno;
                        casasJogadas.Remove(jogada);
                    }
                }
            }
        }

        public static void MostrarGanhador(string turno)
        {
            Console.WriteLine($"\nPARABÉNS!! {turno} VENCEU!");
        }
    }
}
