using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU;

            int randomInt;

            

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;


                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.Write("Choose between ROCK, PAPER and SCISSORS:     ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);     // This chooses a number between 1 and 4 (excluding 4)

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("CPU chooses ROCK");
                            if (inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.WriteLine("Player wins!! \n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.WriteLine("CPU wins!! \n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("CPU chooses PAPER");
                            if (inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.WriteLine("Player wins!! \n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.WriteLine("CPU wins!! \n\n");
                                scoreCPU++;
                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("CPU chooses SCISSORS");
                            if (inputPlayer == "SCISSORS" || inputPlayer == "scissors")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK" || inputPlayer == "rock")
                            {
                                Console.WriteLine("Player wins!! \n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "paper")
                            {
                                Console.WriteLine("CPU wins!! \n\n");
                                scoreCPU++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid Entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPlayer:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);       // the 0 and the 1 is a placeholder for a variable
                                                                                                            // so where the 0 is will be the int scoreplayer and where the 1 is will be the int scoreCPU
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player won!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU won!");
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();

                if(loop == "y")
                {
                    playAgain = true;
                    Console.Clear();           // This will clear the sreen. So at the beginning of the game you will first see a black screen and then the beginning of the new game and not the old game 
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }

            }
        }
    }
}
