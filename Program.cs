using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;
                int round = 1;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    bool ask = true;
                    do
                    {
                        Console.Write("Wybierz PAPIER, KAMIEŃ albo NOŻYCE.\nNaciśnij \"p\", \"k\" albo \"n\":");
                        inputPlayer = Console.ReadLine();
                        inputPlayer = inputPlayer.ToUpper();
                        Console.Clear();
                        Console.WriteLine("Runda: {0}", round);

                        if (inputPlayer == "P")
                        {
                            Console.WriteLine("Wybrałeś PAPIER");
                            ask = false;
                        }
                        else if (inputPlayer == "K")
                        {
                            Console.WriteLine("Wybrałeś KAMIEŃ");
                            ask = false;
                        }
                        else if (inputPlayer == "N")
                        {
                            Console.WriteLine("Wybrałeś NOŻYCE");
                            ask = false;
                        }
                        else if (inputPlayer == "Q")
                        {
                            Console.Clear();
                            Console.WriteLine("Do widzenia!\nNaciśnij \"Enter\"");
                            Console.ReadLine();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy wybór!\n");
                        }
                    } while (ask);

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            Console.WriteLine("Komputer wybrał PAPIER");
                            if (inputPlayer == "P")
                            {
                                Console.WriteLine("REMIS!\n\n");
                            }
                            else if (inputPlayer == "K")
                            {
                                Console.WriteLine("KOMPUTER WYGRYWA!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "N")
                            {
                                Console.WriteLine("WYGRYWASZ!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Komputer wybrał KAMIEŃ");
                            if (inputPlayer == "K")
                            {
                                Console.WriteLine("REMIS!\n\n");
                            }
                            else if (inputPlayer == "N")
                            {
                                Console.WriteLine("KOMPUTER WYGRYWA!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "P")
                            {
                                Console.WriteLine("WYGRYWASZ!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Komputer wybrał NOŻYCE");
                            if (inputPlayer == "N")
                            {
                                Console.WriteLine("REMIS!\n\n");
                            }
                            else if (inputPlayer == "P")
                            {
                                Console.WriteLine("KOMPUTER WYGRYWA!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "K")
                            {
                                Console.WriteLine("WYGRYWASZ!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        default:
                            break;
                    }

                    round++;
                    Console.WriteLine("Punkty:\tGRACZ:\t{0}\tKOMPUTER:\t{1}\n", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("WYGRAŁEŚ!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Komputer WYGRAŁ!");
                }
                else
                {

                }

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\nCzy chcesz zagrać jeszce raz? (t/n)");
                    string loop = Console.ReadLine();
                    loop = loop.ToUpper();

                    if (loop == "T")
                    {
                        playAgain = true;
                        exit = true;
                        Console.Clear();
                    }
                    else if (loop == "N")
                    {
                        playAgain = false;
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy wybór!\n");
                    }
                }
            }
        }
    }
}
