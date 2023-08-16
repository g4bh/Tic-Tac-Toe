namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("    _                                 _                            _   _             \r\n   (_)   ___     __ _    ___       __| |   __ _    __   __   ___  | | | |__     __ _ \r\n   | |  / _ \\   / _` |  / _ \\     / _` |  / _` |   \\ \\ / /  / _ \\ | | | '_ \\   / _` |\r\n   | | | (_) | | (_| | | (_) |   | (_| | | (_| |    \\ V /  |  __/ | | | | | | | (_| |\r\n  _/ |  \\___/   \\__, |  \\___/     \\__,_|  \\__,_|     \\_/    \\___| |_| |_| |_|  \\__,_|\r\n |__/           |___/                                                                ");
            Console.WriteLine("");
            Console.WriteLine("Objetivo: Para jogar, digite qual posição do tabuleiro deseja jogar a peça.\n");
            Console.WriteLine("Clique em ENTER para INICIAR!");
            Console.WriteLine("");

            string[,] matriz = new string[3,3];

            int posicao = 1;
            int tentativas = 0;
            string turno = "X";

            List<string> casasJogadas = new List<string>();

            //Populando a tabela
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matriz[i, j] = posicao.ToString();
                    casasJogadas.Add(posicao.ToString());
                    Console.Write($" [ {matriz[i, j]} ]" );
                    posicao++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();


            //Substituindo os numeros por peças
            while (tentativas < 9) {

                Console.WriteLine() ;
                Console.WriteLine($"Vez de '{turno}'");
                Console.Write("Digite a posição da casa que deseja jogar: ");
                
                string jogada = Console.ReadLine();
                Console.WriteLine(' ');


                while (!casasJogadas.Contains(jogada))
                {
                    Console.Write("Jogada INVÁLIDA! Digite a posição da casa novamente: ");
                    jogada = Console.ReadLine();
                    Console.WriteLine(' ');
                }


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


                for (int i = 0; i<matriz.GetLength(0);i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++) {
                        Console.Write($" [ {matriz[i, j]} ]");
                    }
                    Console.WriteLine() ;
                }


                //Condições de vitória
                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] || matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    Console.WriteLine($"\nPARABÉNS!! {turno} VENCEU!");
                    break;
                }
                else if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] || matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] || matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                {
                    Console.WriteLine($"\nPARABÉNS!! {turno} VENCEU!");
                    break;
                }
                else if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] || matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] || matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                {
                    Console.WriteLine($"\nPARABÉNS!! {turno} VENCEU!");
                    break;
                }
                else { 
                }


                //Troca de turno
                if (turno == "X")
                {
                    turno = "O";
                }
                else
                {
                    turno = "X";
                }

                tentativas++;

            }

            Console.WriteLine("\nFIM DO JOGO!");
            
        }
    }
}
