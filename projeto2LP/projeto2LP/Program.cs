using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2LP
{
    public class Program
    {




        public static void Main(string[] args)
        {


            short t = 1;



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

            ///////////////////////////////////////////////////////////////////////////
            string[,] agentes = new string[colunas, linhas];
            string tecla = "w";
            short humanos = nHumanos;
            short zombies = nZombies;
            short humanosjog = PlayHumanos;
            short zombiesjog = PlayZombies;
            int totalagentes = ((int)nHumanos + (int)nZombies);
            int total = (agentes.Length - totalagentes);
            int totalJog = (PlayHumanos + PlayZombies);
            int totalJogtemp = 0;
            int[][] savedpos = new int[totalJog][];
            Random rand = new Random();
            int tipo = 1;
            bool Gravou = false;
            bool[] jogaveis = new bool[totalJog];

            Console.WriteLine(colunas);
            Console.WriteLine(linhas);
            Console.WriteLine(nHumanos);
            Console.WriteLine(nZombies);
            Console.WriteLine(PlayHumanos);
            Console.WriteLine(PlayZombies);
            Console.WriteLine(turnos);
            Console.WriteLine(agentes.Length);
            Console.WriteLine(total);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if ((total + totalagentes) > 0)
                    {
                        Gravou = false;
                        while (Gravou == false)
                        {
                            tipo = rand.Next(1, 10);

                            switch (tipo)
                            {

                                case 1:
                                    if (humanos > 0 && humanos > humanosjog)
                                    {
                                        Gravou = true;
                                        agentes[j, i] = "  h  ";
                                        humanos--;
                                        totalagentes--;



                                    }

                                    break;
                                case 2:
                                    if (humanosjog > 0 && humanos > 0)
                                    {
                                        Gravou = true;
                                        agentes[j, i] = "  H  ";
                                        humanosjog--;
                                        humanos--;

                                    }
                                    break;
                                case 3:
                                    if (zombiesjog > 0 && zombies > 0)
                                    {
                                        Gravou = true;
                                        agentes[j, i] = "  Z  ";
                                        zombiesjog--;
                                        zombies--;


                                    }
                                    break;
                                case 4:
                                    if (zombies > 0 && zombies > zombiesjog)
                                    {
                                        Gravou = true;
                                        agentes[j, i] = "  z  ";
                                        zombies--;
                                        totalagentes--;
                                    }
                                    break;
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                case 9:

                                    if (total > 0)
                                    {
                                        Gravou = true;
                                        agentes[j, i] = "  .  ";
                                        total--;
                                    }
                                    break;

                            }

                        }

                    }

                }
            }

            for (int p = 0; p < totalJog; p++)
            {
                savedpos[p] = new int[2];

            }
            totalJogtemp = 0;
            while (t <= turnos)
            {
                totalJogtemp = 0;
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (agentes[j, i] == "  H  " || agentes[j, i] == "  Z  ")

                        {

                            savedpos[totalJogtemp][0] = -1;
                            savedpos[totalJogtemp][1] = -1;
                            totalJogtemp++;

                        }
                    }

                }

                totalJogtemp = 0;

                Console.WriteLine();
                Console.WriteLine("turno: " + t);
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (agentes[j, i] == "  H  " || agentes[j, i] == "  Z  ")

                        {

                            savedpos[totalJogtemp][0] = i;
                            savedpos[totalJogtemp][1] = j;
                            jogaveis[totalJogtemp] = false;
                            totalJogtemp++;

                        }

                        Console.Write(agentes[j, i]);
                    }
                    Console.WriteLine();
                }
                for (int p = 0; p < totalJog; p++)
                {
                    if (savedpos[p][0] >= 0 && savedpos[p][1] >= 0 && jogaveis[p] == false)
                    {

                        Console.WriteLine("linha: " + savedpos[p][0]);
                        Console.WriteLine("coluna: " + savedpos[p][1]);
                        tecla = "";
                        while (tecla != "W" && tecla != "w" && tecla != "A" && tecla != "a" && tecla != "S" && tecla != "s" && tecla != "D" && tecla != "d")
                        {


                            Console.WriteLine("Insira para onde se quer mover: ");
                            Console.WriteLine();
                            tecla = Console.ReadLine();
                            switch (tecla)
                            {
                                case "w":
                                case "W":
                                    if (savedpos[p][0] - 1 >= 0)
                                    {
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  H  " && agentes[savedpos[p][1], savedpos[p][0] - 1] == "  .  ")
                                        {
                                            agentes[savedpos[p][1], savedpos[p][0] - 1] = "  H  ";
                                            agentes[savedpos[p][1], savedpos[p][0]] = "  .  ";
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1], savedpos[p][0] - 1] == "  .  ")
                                        {
                                            agentes[savedpos[p][1], savedpos[p][0] - 1] = "  Z  ";
                                            agentes[savedpos[p][1], savedpos[p][0]] = "  .  ";
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1], savedpos[p][0] - 1] == "  h  ")
                                        {
                                            agentes[savedpos[p][1], savedpos[p][0] - 1] = "  z  ";
                                            nHumanos--;
                                            nZombies++;
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1], savedpos[p][0] - 1] == "  H  ")
                                        {
                                            agentes[savedpos[p][1], savedpos[p][0] - 1] = "  z  ";
                                            nHumanos--;
                                            nZombies++;
                                            totalJog--;
                                            jogaveis[p] = true;
                                            totalJogtemp--;

                                        }

                                    }

                                    break;

                                case "a":
                                case "A":
                                    if (savedpos[p][1] - 1 >= 0)
                                    {
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  H  " && agentes[savedpos[p][1] - 1, savedpos[p][0]] == "  .  ")
                                        {
                                            agentes[savedpos[p][1] - 1, savedpos[p][0]] = "  H  ";
                                            agentes[savedpos[p][1], savedpos[p][0]] = "  .  ";
                                            jogaveis[p] = true;
                                            totalJogtemp--;


                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1] - 1, savedpos[p][0]] == "  .  ")
                                        {
                                            agentes[savedpos[p][1] - 1, savedpos[p][0]] = "  Z  ";
                                            agentes[savedpos[p][1], savedpos[p][0]] = "  .  ";
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1] - 1, savedpos[p][0]] == "  h  ")
                                        {
                                            agentes[savedpos[p][1] - 1, savedpos[p][0]] = "  z  ";
                                            nHumanos--;
                                            nZombies++;
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1] - 1, savedpos[p][0]] == "  H  ")
                                        {
                                            agentes[savedpos[p][1] - 1, savedpos[p][0]] = "  z  ";
                                            nHumanos--;
                                            nZombies++;
                                            totalJog--;
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                    }

                                    break;
                                case "D":
                                case "d":
                                    if (savedpos[p][1] + 1 < colunas)
                                    {
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  H  " && agentes[savedpos[p][1] + 1, savedpos[p][0]] == "  .  ")
                                        {
                                            agentes[savedpos[p][1] + 1, savedpos[p][0]] = "  H  ";
                                            agentes[savedpos[p][1], savedpos[p][0]] = "  .  ";
                                            jogaveis[p] = true;
                                            totalJogtemp--;


                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1] + 1, savedpos[p][0]] == "  .  ")
                                        {
                                            agentes[savedpos[p][1] + 1, savedpos[p][0]] = "  Z  ";
                                            agentes[savedpos[p][1], savedpos[p][0]] = "  .  ";
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1] + 1, savedpos[p][0]] == "  h  ")
                                        {
                                            agentes[savedpos[p][1] + 1, savedpos[p][0]] = "  z  ";
                                            nHumanos--;
                                            nZombies++;
                                            totalJogtemp--;

                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1] + 1, savedpos[p][0]] == "  H  ")
                                        {
                                            agentes[savedpos[p][1] + 1, savedpos[p][0]] = "  z  ";
                                            nHumanos--;
                                            nZombies++;
                                            totalJog--;
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                    }

                                    break;
                                case "S":
                                case "s":
                                    if (savedpos[p][0] + 1 <= linhas)
                                    {
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  H  " && agentes[savedpos[p][1], savedpos[p][0] + 1] == "  .  ")
                                        {
                                            agentes[savedpos[p][1], savedpos[p][0] + 1] = "  H  ";
                                            agentes[savedpos[p][1], savedpos[p][0]] = "  .  ";
                                            jogaveis[p] = true;
                                            totalJogtemp--;


                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1], savedpos[p][0] + 1] == "  .  ")
                                        {
                                            agentes[savedpos[p][1], savedpos[p][0] + 1] = "  Z  ";
                                            agentes[savedpos[p][1], savedpos[p][0]] = "  .  ";
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1], savedpos[p][0] + 1] == "  h  ")
                                        {
                                            agentes[savedpos[p][1], savedpos[p][0] + 1] = "  z  ";
                                            nHumanos--;
                                            nZombies++;
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                        if (agentes[savedpos[p][1], savedpos[p][0]] == "  Z  " && agentes[savedpos[p][1], savedpos[p][0] + 1] == "  H  ")
                                        {
                                            agentes[savedpos[p][1], savedpos[p][0] + 1] = "  z  ";
                                            nHumanos--;
                                            nZombies++;
                                            totalJog--;
                                            jogaveis[p] = true;
                                            totalJogtemp--;
                                        }
                                    }

                                    break;
                                default:
                                    Console.WriteLine("Tecla invalida Selecione W,A,S ou D");
                                    break;

                            }
                        }

                        for (int i = 0; i < linhas; i++)
                        {

                            for (int j = 0; j < colunas; j++)
                            {
                                if (tecla == "W" || tecla == "w" || tecla == "A" || tecla == "a" || tecla == "S" || tecla == "s" || tecla == "D" || tecla == "d")
                                {
                                    switch (tecla)
                                    {
                                        case "W":
                                        case "w":
                                            if (i - 1 >= 0)
                                            {
                                                if (savedpos[p][0] > 0)
                                                {
                                                    savedpos[p][0] = i - 1;
                                                    savedpos[p][1] = j;
                                                }


                                            }
                                            break;
                                        case "S":
                                        case "s":
                                            if (i + 1 < linhas)
                                            {
                                                if (savedpos[p][0] < linhas - 1)
                                                {
                                                    savedpos[p][0] = i + 1;
                                                    savedpos[p][1] = j;
                                                }


                                            }
                                            break;
                                        case "A":
                                        case "a":
                                            if (j - 1 >= 0)
                                            {
                                                if (savedpos[p][1] > 0)
                                                {
                                                    savedpos[p][0] = i;
                                                    savedpos[p][1] = j - 1;
                                                }



                                            }
                                            break;
                                        case "D":
                                        case "d":
                                            if (j + 1 < colunas)
                                            {
                                                if (savedpos[p][1] > colunas - 1)
                                                {
                                                    savedpos[p][0] = i;
                                                    savedpos[p][1] = j + 1;
                                                }


                                            }
                                            break;


                                    }


                                }

                                Console.Write(agentes[j, i]);

                            }
                            Console.WriteLine();
                        }
                    }
                }

                Console.WriteLine();
                t++;





                Console.ReadKey();
            }

            Console.WriteLine(colunas);
            Console.WriteLine(linhas);
            Console.WriteLine(nHumanos);
            Console.WriteLine(nZombies);
            Console.WriteLine(PlayHumanos);
            Console.WriteLine(PlayZombies);
            Console.WriteLine(turnos);
            Console.WriteLine(agentes.Length);
            Console.WriteLine(agentes[0, 0]);
        }
    }
}

