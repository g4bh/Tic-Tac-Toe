namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("    _                                 _                            _   _             \r\n   (_)   ___     __ _    ___       __| |   __ _    __   __   ___  | | | |__     __ _ \r\n   | |  / _ \\   / _` |  / _ \\     / _` |  / _` |   \\ \\ / /  / _ \\ | | | '_ \\   / _` |\r\n   | | | (_) | | (_| | | (_) |   | (_| | | (_| |    \\ V /  |  __/ | | | | | | | (_| |\r\n  _/ |  \\___/   \\__, |  \\___/     \\__,_|  \\__,_|     \\_/    \\___| |_| |_| |_|  \\__,_|\r\n |__/           |___/                                                                ");
            Console.WriteLine("");
            Console.WriteLine("Para jogar, digite qual posição do tabuleiro deseja jogar a peça.");
            Console.WriteLine("");

            string[,] matriz = new string[3,3];

            int posicao = 1;
            int tentativas = 0;
            string turno = "X";

            //Populando a tabela
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matriz[i, j] = "[ " + posicao.ToString() + " ]";
                    posicao++;
                }
            }

            
            //Mostrando a tabela
            for (int i = 0;i < matriz.GetLength(0); i++)
            {
                for (int j = 0;j < matriz.GetLength(1);j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


            //Substituindo os numeors por peças
            while (tentativas < 9) {

                Console.Write("Digite a posição da casa que deseja jogar: ");
                int jogada = int.Parse(Console.ReadLine());



            }

            
        }
    }
}