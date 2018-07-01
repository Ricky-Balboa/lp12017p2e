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

            /// <summary>
            /// 
            /// </summary>
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
            /// Este for compara os argumentos da linha de comandos e guarda-os 
            /// nas respetivas variaveis
            /// iniciando assim o jogo com as opçoes selecionadas pelo 
            /// utilizador.
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


<<<<<<< HEAD
            ///////////////////////////////////////////////////////////////////////////
=======
            ///////////////////////////////////////////////////////////////////
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda

            string[,] agentes = new string[colunas, linhas];
            string tecla = "";
            short humanos = nHumanos;
            short zombies = nZombies;
            short humanosjog = PlayHumanos;
            short zombiesjog = PlayZombies;
            int totalagentes = ((int)nHumanos + (int)nZombies);
            int total = (agentes.Length - totalagentes);
            int totaltemp = 0;
            int totalJog = (PlayHumanos + PlayZombies);
            int totalJogtemp = 0;
            int[][] savedposJog = new int[totalJog][];
            int[][] savedpos = new int[nHumanos + nZombies][];
<<<<<<< HEAD
            int p = -1;
=======
            int p = 0;
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda
            int pAI = 0;
            Random rand = new Random();
            int tipo = 1;
            bool Gravou = false;
            bool[] jogaveis = new bool[totalJog];
            bool[] jogoAI = new bool[nHumanos + nZombies];




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
            for (int i = 0; i < (nHumanos + nZombies); i++)
            {
                savedpos[i] = new int[2];
            }

            for (int i = 0; i < totalJog; i++)
            {
                savedposJog[i] = new int[2];

            }

            totalJogtemp = 0;
            totaltemp = 0;
            while (t <= turnos)
            {
                p = 0;
                pAI = 0;
                totalJogtemp = 0;

                totaltemp = 0;
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
<<<<<<< HEAD
                        if (agentes[j, i] == "  H  " || agentes[j, i] == "  Z  ")
=======
                        if (agentes[j, i] == "  H  " || agentes[j, i] ==
                            "  Z  ")
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda
                        {
                            savedposJog[totalJogtemp][0] = -1;
                            savedposJog[totalJogtemp][1] = -1;
                            totalJogtemp++;
                        }
<<<<<<< HEAD
                        if (agentes[j, i] == "  h  " || agentes[j, i] == "  z  ")
=======
                        if (agentes[j, i] == "  h  " ||
                            agentes[j, i] == "  z  ")
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda
                        {
                            savedpos[totaltemp][0] = -1;
                            savedpos[totaltemp][1] = -1;
                            totaltemp++;
                        }
                    }
                }
                totaltemp = 0;
                totalJogtemp = 0;

                Console.WriteLine();
                Console.WriteLine("turno: " + t);
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (agentes[j, i] == "  H  " ||
                            agentes[j, i] == "  Z  ")

                        {
                            savedposJog[totalJogtemp][0] = i;
                            savedposJog[totalJogtemp][1] = j;
                            jogaveis[totalJogtemp] = false;
                            totalJogtemp++;

                        }
<<<<<<< HEAD
                        if (agentes[j, i] == "  h  " || agentes[j, i] == "  z  ")
=======
                        if (agentes[j, i] == "  h  " ||
                            agentes[j, i] == "  z  ")
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda
                        {
                            savedpos[totaltemp][0] = i;
                            savedpos[totaltemp][1] = j;
                            jogoAI[totaltemp] = false;
                            totaltemp++;
                        }

                        Console.Write(agentes[j, i]);
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
<<<<<<< HEAD

                        if (agentes[j, i] == "  H  " || agentes[j, i] == "  Z  ")
                        {
                            if (savedposJog[p][0] >= 0 && savedposJog[p][1] >= 0)
                            {
                                if (jogaveis[p] == false)
                                {
=======
                        if (agentes[j, i] == "  H  " ||
                            agentes[j, i] == "  Z  ")
                        {
                            if (savedposJog[p][0] >= 0 && savedposJog[p][1] >=
                                0 && jogaveis[p] == false)
                            {
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda

                                Console.WriteLine("linha: " + savedposJog[p][0]);
                                Console.WriteLine("coluna: " + savedposJog[p][1]);
                                tecla = "";
                                while (tecla != "W" && tecla != "w" && tecla !=
                                    "A" && tecla != "a" && tecla != "S" &&
                                    tecla != "s" && tecla != "D" && tecla != "d")
                                {


<<<<<<< HEAD
                                    Console.WriteLine("linha: " + savedposJog[p][0]);
                                    Console.WriteLine("coluna: " + savedposJog[p][1]);
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
                                                if (savedposJog[p][0]  > 0)
                                                {
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  H  " && agentes[savedposJog[p][1], savedposJog[p][0] - 1] == "  .  ")
                                                    {
                                                        agentes[savedposJog[p][1], savedposJog[p][0] - 1] = "  H  ";
                                                        agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] - 1] == "  .  ")
                                                    {
                                                        agentes[savedposJog[p][1], savedposJog[p][0] - 1] = "  Z  ";
                                                        agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] - 1] == "  h  ")
                                                    {
                                                        agentes[savedposJog[p][1], savedposJog[p][0] - 1] = "  z  ";
                                                        nHumanos--;
                                                        nZombies++;
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] - 1] == "  H  ")
                                                    {
                                                        agentes[savedposJog[p][1], savedposJog[p][0] - 1] = "  z  ";
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
                                                if (savedposJog[p][1] > 0)
                                                {
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  H  " && agentes[savedposJog[p][1] - 1, savedposJog[p][0]] == "  .  ")
                                                    {
                                                        agentes[savedposJog[p][1] - 1, savedposJog[p][0]] = "  H  ";
                                                        agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;


                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] - 1, savedposJog[p][0]] == "  .  ")
                                                    {
                                                        agentes[savedposJog[p][1] - 1, savedposJog[p][0]] = "  Z  ";
                                                        agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] - 1, savedposJog[p][0]] == "  h  ")
                                                    {
                                                        agentes[savedposJog[p][1] - 1, savedposJog[p][0]] = "  z  ";
                                                        nHumanos--;
                                                        nZombies++;
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] - 1, savedposJog[p][0]] == "  H  ")
                                                    {
                                                        agentes[savedposJog[p][1] - 1, savedposJog[p][0]] = "  z  ";
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
                                                if (savedposJog[p][1] + 1 < colunas)
                                                {
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  H  " && agentes[savedposJog[p][1] + 1, savedposJog[p][0]] == "  .  ")
                                                    {
                                                        agentes[savedposJog[p][1] + 1, savedposJog[p][0]] = "  H  ";
                                                        agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;


                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] + 1, savedposJog[p][0]] == "  .  ")
                                                    {
                                                        agentes[savedposJog[p][1] + 1, savedposJog[p][0]] = "  Z  ";
                                                        agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] + 1, savedposJog[p][0]] == "  h  ")
                                                    {
                                                        agentes[savedposJog[p][1] + 1, savedposJog[p][0]] = "  z  ";
                                                        nHumanos--;
                                                        nZombies++;
                                                        totalJogtemp--;
                                                        jogaveis[p] = true;

                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] + 1, savedposJog[p][0]] == "  H  ")
                                                    {
                                                        agentes[savedposJog[p][1] + 1, savedposJog[p][0]] = "  z  ";
                                                        nHumanos--;
                                                        nZombies++;
                                                        totalJog--;
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                }
=======
                                    Console.WriteLine("Insira para onde se quer mover: ");
                                    Console.WriteLine();
                                    tecla = Console.ReadLine();
                                    switch (tecla)
                                    {
                                        case "w":
                                        case "W":
                                            if (savedposJog[p][0] - 1 >= 0)
                                            {
                                                if (agentes[savedposJog[p][1],
                                                    savedposJog[p][0]] == "  H  " && agentes[savedposJog[p][1], savedposJog[p][0] - 1] == "  .  ")
                                                {
                                                    agentes[savedposJog[p][1], savedposJog[p][0] - 1] = "  H  ";
                                                    agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] - 1] == "  .  ")
                                                {
                                                    agentes[savedposJog[p][1], savedposJog[p][0] - 1] = "  Z  ";
                                                    agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] - 1] == "  h  ")
                                                {
                                                    agentes[savedposJog[p][1], savedposJog[p][0] - 1] = "  z  ";
                                                    nHumanos--;
                                                    nZombies++;
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] - 1] == "  H  ")
                                                {
                                                    agentes[savedposJog[p][1], savedposJog[p][0] - 1] = "  z  ";
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
                                            if (savedposJog[p][1] - 1 >= 0)
                                            {
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  H  " && agentes[savedposJog[p][1] - 1, savedposJog[p][0]] == "  .  ")
                                                {
                                                    agentes[savedposJog[p][1] - 1, savedposJog[p][0]] = "  H  ";
                                                    agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda

                                                break;
                                            case "S":
                                            case "s":
                                                if (savedposJog[p][0] +1 < linhas)
                                                {
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  H  " && agentes[savedposJog[p][1], savedposJog[p][0] + 1] == "  .  ")
                                                    {
                                                        agentes[savedposJog[p][1], savedposJog[p][0] + 1] = "  H  ";
                                                        agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;


                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] + 1] == "  .  ")
                                                    {
                                                        agentes[savedposJog[p][1], savedposJog[p][0] + 1] = "  Z  ";
                                                        agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] + 1] == "  h  ")
                                                    {
                                                        agentes[savedposJog[p][1], savedposJog[p][0] + 1] = "  z  ";
                                                        nHumanos--;
                                                        nZombies++;
                                                        jogaveis[p] = true;
                                                        totalJogtemp--;
                                                    }
                                                    if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] + 1] == "  H  ")
                                                    {
                                                        agentes[savedposJog[p][1], savedposJog[p][0] + 1] = "  z  ";
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

<<<<<<< HEAD
                                        }
                                    }

                                    for (int ii = 0; ii < linhas; ii++)
                                    {

                                        for (int jj = 0; jj < colunas; jj++)
                                        {
                                            if (tecla == "W" || tecla == "w" || tecla == "A" || tecla == "a" || tecla == "S" || tecla == "s" || tecla == "D" || tecla == "d")
                                            {
                                                switch (tecla)
                                                {
                                                    case "W":
                                                    case "w":
                                                        if (ii - 1 >= 0)
                                                        {
                                                            if (savedposJog[p][0] > 0)
                                                            {
                                                                savedposJog[p][0] = ii - 1;
                                                                savedposJog[p][1] = jj;
                                                            }


                                                        }
                                                        break;
                                                    case "S":
                                                    case "s":
                                                        if (ii + 1 < linhas)
                                                        {
                                                            if (savedposJog[p][0] < linhas - 1)
                                                            {
                                                                savedposJog[p][0] = ii + 1;
                                                                savedposJog[p][1] = jj;
                                                            }


                                                        }
                                                        break;
                                                    case "A":
                                                    case "a":
                                                        if (jj - 1 >= 0)
                                                        {
                                                            if (savedposJog[p][1] > 0)
                                                            {
                                                                savedposJog[p][0] = ii;
                                                                savedposJog[p][1] = jj - 1;
                                                            }



                                                        }
                                                        break;
                                                    case "D":
                                                    case "d":
                                                        if (jj + 1 < colunas)
                                                        {
                                                            if (savedposJog[p][1] > colunas - 1)
                                                            {
                                                                savedposJog[p][0] = ii;
                                                                savedposJog[p][1] = jj + 1;
                                                            }


                                                        }
                                                        break;


                                                }


=======
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] - 1, savedposJog[p][0]] == "  .  ")
                                                {
                                                    agentes[savedposJog[p][1] - 1, savedposJog[p][0]] = "  Z  ";
                                                    agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] - 1, savedposJog[p][0]] == "  h  ")
                                                {
                                                    agentes[savedposJog[p][1] - 1, savedposJog[p][0]] = "  z  ";
                                                    nHumanos--;
                                                    nZombies++;
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] - 1, savedposJog[p][0]] == "  H  ")
                                                {
                                                    agentes[savedposJog[p][1] - 1, savedposJog[p][0]] = "  z  ";
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
                                            if (savedposJog[p][1] + 1 <= colunas)
                                            {
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  H  " && agentes[savedposJog[p][1] + 1, savedposJog[p][0]] == "  .  ")
                                                {
                                                    agentes[savedposJog[p][1] + 1, savedposJog[p][0]] = "  H  ";
                                                    agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;


                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] + 1, savedposJog[p][0]] == "  .  ")
                                                {
                                                    agentes[savedposJog[p][1] + 1, savedposJog[p][0]] = "  Z  ";
                                                    agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] + 1, savedposJog[p][0]] == "  h  ")
                                                {
                                                    agentes[savedposJog[p][1] + 1, savedposJog[p][0]] = "  z  ";
                                                    nHumanos--;
                                                    nZombies++;
                                                    totalJogtemp--;
                                                    jogaveis[p] = true;

                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1] + 1, savedposJog[p][0]] == "  H  ")
                                                {
                                                    agentes[savedposJog[p][1] + 1, savedposJog[p][0]] = "  z  ";
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
                                            if (savedposJog[p][0] + 1 <= linhas)
                                            {
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  H  " && agentes[savedposJog[p][1], savedposJog[p][0] + 1] == "  .  ")
                                                {
                                                    agentes[savedposJog[p][1], savedposJog[p][0] + 1] = "  H  ";
                                                    agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;


                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] + 1] == "  .  ")
                                                {
                                                    agentes[savedposJog[p][1], savedposJog[p][0] + 1] = "  Z  ";
                                                    agentes[savedposJog[p][1], savedposJog[p][0]] = "  .  ";
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] + 1] == "  h  ")
                                                {
                                                    agentes[savedposJog[p][1], savedposJog[p][0] + 1] = "  z  ";
                                                    nHumanos--;
                                                    nZombies++;
                                                    jogaveis[p] = true;
                                                    totalJogtemp--;
                                                }
                                                if (agentes[savedposJog[p][1], savedposJog[p][0]] == "  Z  " && agentes[savedposJog[p][1], savedposJog[p][0] + 1] == "  H  ")
                                                {
                                                    agentes[savedposJog[p][1], savedposJog[p][0] + 1] = "  z  ";
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

                                for (int ii = 0; ii < linhas; ii++)
                                {

                                    for (int jj = 0; jj < colunas; jj++)
                                    {
                                        if (tecla == "W" || tecla == "w" || tecla == "A" || tecla == "a" || tecla == "S" || tecla == "s" || tecla == "D" || tecla == "d")
                                        {
                                            switch (tecla)
                                            {
                                                case "W":
                                                case "w":
                                                    if (ii - 1 >= 0)
                                                    {
                                                        if (savedposJog[p][0] > 0)
                                                        {
                                                            savedposJog[p][0] = ii - 1;
                                                            savedposJog[p][1] = jj;
                                                        }


                                                    }
                                                    break;
                                                case "S":
                                                case "s":
                                                    if (ii + 1 < linhas)
                                                    {
                                                        if (savedposJog[p][0] < linhas - 1)
                                                        {
                                                            savedposJog[p][0] = ii + 1;
                                                            savedposJog[p][1] = jj;
                                                        }


                                                    }
                                                    break;
                                                case "A":
                                                case "a":
                                                    if (jj - 1 >= 0)
                                                    {
                                                        if (savedposJog[p][1] > 0)
                                                        {
                                                            savedposJog[p][0] = ii;
                                                            savedposJog[p][1] = jj - 1;
                                                        }



                                                    }
                                                    break;
                                                case "D":
                                                case "d":
                                                    if (jj + 1 < colunas)
                                                    {
                                                        if (savedposJog[p][1] > colunas - 1)
                                                        {
                                                            savedposJog[p][0] = ii;
                                                            savedposJog[p][1] = jj + 1;
                                                        }


                                                    }
                                                    break;


>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda
                                            }

                                            Console.Write(agentes[jj, ii]);

                                        }
<<<<<<< HEAD
                                        Console.WriteLine();
                                    }
                                }
                            }
                            if (p + 1 < PlayHumanos + PlayZombies)
=======

                                        Console.Write(agentes[jj, ii]);

                                    }
                                    Console.WriteLine();
                                }
                            }
                            if (p <= PlayHumanos + PlayZombies)
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda
                            {
                                p++;
                            }

                        }
                        if (agentes[j, i] == "  h  " || agentes[j, i] == "  z  ")
                        {
                            if (savedpos[pAI][0] >= 0 && savedpos[pAI][1] >= 0 && jogoAI[pAI] == false)
                            {
                                tipo = rand.Next(1, 5);
                                switch (tipo)
                                {
                                    case 1:
                                        if (savedpos[pAI][0] - 1 >= 0)
                                        {
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  h  " && agentes[savedpos[pAI][1], savedpos[pAI][0] - 1] == "  .  ")
                                            {
                                                agentes[savedpos[pAI][1], savedpos[pAI][0] - 1] = "  h  ";
                                                agentes[savedpos[pAI][1], savedpos[pAI][0]] = "  .  ";
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1], savedpos[pAI][0] - 1] == "  .  ")
                                            {
                                                agentes[savedpos[pAI][1], savedpos[pAI][0] - 1] = "  z  ";
                                                agentes[savedpos[pAI][1], savedpos[pAI][0]] = "  .  ";
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1], savedpos[pAI][0] - 1] == "  h  ")
                                            {
                                                agentes[savedpos[pAI][1], savedpos[pAI][0] - 1] = "  z  ";
                                                nHumanos--;
                                                nZombies++;
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1], savedpos[pAI][0] - 1] == "  H  ")
                                            {
                                                agentes[savedpos[pAI][1], savedpos[pAI][0] - 1] = "  z  ";
                                                nHumanos--;
                                                nZombies++;
                                                totalJog--;
                                                jogoAI[pAI] = true;
                                                totaltemp--;

                                            }

                                        }

                                        break;

                                    case 2:
                                        if (savedpos[pAI][1] - 1 >= 0)
                                        {
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  h  " && agentes[savedpos[pAI][1] - 1, savedpos[pAI][0]] == "  .  ")
                                            {
                                                agentes[savedpos[pAI][1] - 1, savedpos[pAI][0]] = "  h  ";
                                                agentes[savedpos[pAI][1], savedpos[pAI][0]] = "  .  ";
                                                jogoAI[pAI] = true;
                                                totaltemp--;


                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1] - 1, savedpos[pAI][0]] == "  .  ")
                                            {
                                                agentes[savedpos[pAI][1] - 1, savedpos[pAI][0]] = "  z  ";
                                                agentes[savedpos[pAI][1], savedpos[pAI][0]] = "  .  ";
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1] - 1, savedpos[pAI][0]] == "  h  ")
                                            {
                                                agentes[savedpos[pAI][1] - 1, savedpos[pAI][0]] = "  z  ";
                                                nHumanos--;
                                                nZombies++;
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1] - 1, savedpos[pAI][0]] == "  H  ")
                                            {
                                                agentes[savedpos[pAI][1] - 1, savedpos[pAI][0]] = "  z  ";
                                                nHumanos--;
                                                nZombies++;
                                                totalJog--;
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                        }

                                        break;
                                    case 3:
                                        if (savedpos[pAI][1] + 1 < colunas)
                                        {
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1] + 1, savedpos[pAI][0]] == "  .  ")
                                            {
                                                agentes[savedpos[pAI][1] + 1, savedpos[pAI][0]] = "  z  ";
                                                agentes[savedpos[pAI][1], savedpos[pAI][0]] = "  .  ";
                                                jogoAI[pAI] = true;
                                                totaltemp--;


                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1] + 1, savedpos[pAI][0]] == "  .  ")
                                            {
                                                agentes[savedpos[pAI][1] + 1, savedpos[pAI][0]] = "  z  ";
                                                agentes[savedpos[pAI][1], savedpos[pAI][0]] = "  .  ";
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1] + 1, savedpos[pAI][0]] == "  h  ")
                                            {
                                                agentes[savedpos[pAI][1] + 1, savedpos[pAI][0]] = "  z  ";
                                                nHumanos--;
                                                nZombies++;
                                                totaltemp--;

                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1] + 1, savedpos[pAI][0]] == "  H  ")
                                            {
                                                agentes[savedpos[pAI][1] + 1, savedpos[pAI][0]] = "  z  ";
                                                nHumanos--;
                                                nZombies++;
                                                totalJog--;
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                        }

                                        break;
                                    case 4:
<<<<<<< HEAD
                                        if (savedpos[pAI][0] + 1 < linhas)
=======
                                        if (savedpos[pAI][0] + 1 <= linhas)
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda
                                        {
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  h  " && agentes[savedpos[pAI][1], savedpos[pAI][0] + 1] == "  .  ")
                                            {
                                                agentes[savedpos[pAI][1], savedpos[pAI][0] + 1] = "  h  ";
                                                agentes[savedpos[pAI][1], savedpos[pAI][0]] = "  .  ";
                                                jogoAI[pAI] = true;
                                                totaltemp--;


                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1], savedpos[pAI][0] + 1] == "  .  ")
                                            {
                                                agentes[savedpos[pAI][1], savedpos[pAI][0] + 1] = "  z  ";
                                                agentes[savedpos[pAI][1], savedpos[pAI][0]] = "  .  ";
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1], savedpos[pAI][0] + 1] == "  h  ")
                                            {
                                                agentes[savedpos[pAI][1], savedpos[pAI][0] + 1] = "  z  ";
                                                nHumanos--;
                                                nZombies++;
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                            if (agentes[savedpos[pAI][1], savedpos[pAI][0]] == "  z  " && agentes[savedpos[pAI][1], savedpos[pAI][0] + 1] == "  H  ")
                                            {
                                                agentes[savedpos[pAI][1], savedpos[pAI][0] + 1] = "  z  ";
                                                nHumanos--;
                                                nZombies++;
                                                totalJog--;
                                                jogoAI[pAI] = true;
                                                totaltemp--;
                                            }
                                        }

                                        break;
                                }
                                for (int ii = 0; ii < linhas; ii++)
                                {

                                    for (int jj = 0; jj < colunas; jj++)
                                    {
                                        switch (tipo)
                                        {
                                            case 1:
                                                if (ii - 1 >= 0)
                                                {
                                                    if (savedpos[pAI][0] > 0)
                                                    {
                                                        savedpos[pAI][0] = ii - 1;
                                                        savedpos[pAI][1] = jj;
                                                    }


                                                }
                                                break;
                                            case 2:
                                                if (ii + 1 < linhas)
                                                {
                                                    if (savedpos[pAI][0] < linhas - 1)
                                                    {
                                                        savedpos[pAI][0] = ii + 1;
                                                        savedpos[pAI][1] = jj;
                                                    }


                                                }
                                                break;
                                            case 3:
                                                if (jj - 1 >= 0)
                                                {
                                                    if (savedpos[pAI][1] > 0)
                                                    {
                                                        savedpos[pAI][0] = ii;
                                                        savedpos[pAI][1] = jj - 1;
                                                    }



                                                }
                                                break;
                                            case 4:
                                                if (jj + 1 < colunas)
                                                {
                                                    if (savedpos[pAI][1] > colunas - 1)
                                                    {
                                                        savedpos[pAI][0] = ii;
                                                        savedpos[pAI][1] = jj + 1;
                                                    }


                                                }
                                                break;
                                        }

                                        Console.Write(agentes[jj, ii]);

                                    }
                                    Console.WriteLine();
                                }
                            }
<<<<<<< HEAD
                            if (pAI +1 < nHumanos + nZombies - PlayHumanos - PlayZombies)
=======
                            if (pAI < nHumanos + nZombies - PlayHumanos - PlayZombies)
>>>>>>> 3f0835b669a809206ad87617ca255f82f3004bda
                            {
                                pAI++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                if (nHumanos == 0)
                {
                    t = turnos;
                }

                Console.WriteLine();
                t++;

                Console.ReadKey();
            }
            if (nHumanos > 0)
            {
                Console.WriteLine("OS HUMANOS GANHARAM!");
            }
            else
            {
                Console.WriteLine("OS ZOMBIES GANHARAM!");
            }

            Console.WriteLine(colunas);
            Console.WriteLine(linhas);
            Console.WriteLine(nHumanos);
            Console.WriteLine(nZombies);
            Console.WriteLine(PlayHumanos);
            Console.WriteLine(PlayZombies);
            Console.WriteLine(turnos);
            Console.WriteLine(agentes.Length);
        }
    }
}

