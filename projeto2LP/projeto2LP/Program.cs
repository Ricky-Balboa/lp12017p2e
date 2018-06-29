using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLP1_2
{
    public class Program
    {




        public static void Main(string[] args)
        {
            /// <summary>
            /// cria variavel colunas
            /// </summary>
            short colunas = 0;
            /// <summary>
            /// cria variavel linhas 
            /// </summary>
            short linhas = 0;
            /// <summary>
            /// cria variavel nHumanos
            /// </summary>
            short nHumanos = 0;
            /// <summary>
            /// cria variavel PlayHumanos
            /// </summary>
            short PlayHumanos = 0;
            /// <summary>
            /// cria variavel nZombies
            /// </summary>
            short nZombies = 0;
            /// <summary>
            /// cria variavel PlayZombies
            /// </summary>
            short PlayZombies = 0;
            /// <summary>
            /// cria variavel turnos
            /// </summary>
            short turnos = 0;

            /// <summary>
            /// Este for compara os argumentos da linha de comandos e guarda-os nas respetivas variaveis
            /// iniciando assim o jogo com as opçoes selecionadas pelo utilizador.
            /// </summary>

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-x")
                {
                    colunas = Convert.ToInt16(args[i + 1]);
                }
                if (args[i] == "-y")
                {
                    linhas = Convert.ToInt16(args[i + 1]);
                }
                if (args[i] == "-z")
                {
                    nZombies = Convert.ToInt16(args[i + 1]);
                }
                if (args[i] == "-h")
                {
                    nHumanos = Convert.ToInt16(args[i + 1]);
                }
                if (args[i] == "-Z")
                {
                    PlayZombies = Convert.ToInt16(args[i + 1]);
                }
                if (args[i] == "-H")
                {
                    PlayHumanos = Convert.ToInt16(args[i + 1]);
                }
                if (args[i] == "-t")
                {
                    turnos = Convert.ToInt16(args[i + 1]);
                }
            }

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write("  *  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(colunas);
            Console.WriteLine(linhas);
            Console.WriteLine(nHumanos);
            Console.WriteLine(nZombies);
            Console.WriteLine(PlayHumanos);
            Console.WriteLine(PlayZombies);
            Console.WriteLine(turnos);















        }
    }
}
