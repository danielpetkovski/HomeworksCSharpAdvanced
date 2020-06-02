using System;
using System.Security.Cryptography;

namespace SEDC.ProjectExercise.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool isRunning = true;
            bool playAgain = true;

            int allUserWins = 0;
            int allCpuWins = 0;
            int allDraws = 0;


            while (isRunning)
            {
                Console.WriteLine("Please select option: \n 1-Play \n 2-Stats \n 3-Exit ");

                string option = Console.ReadLine();
                switch (option)
                {

                    //play
                    case "1":
                        playAgain = true;
                        while (playAgain)
                        {

                            int scorePlayer = 0;
                            int scoreCPU = 0;
                            int scoreDraw = 0;

                            while (scorePlayer < 3 && scoreCPU < 3)
                            {


                                Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                                inputPlayer = Console.ReadLine();
                                inputPlayer = inputPlayer.ToUpper();


                                Random rnd = new Random();

                                randomInt = rnd.Next(1, 4);

                                switch (randomInt)
                                {
                                    case 1:
                                        inputCPU = "ROCK";
                                        Console.WriteLine("Computer chose ROCK");
                                        if (inputPlayer == "ROCK")
                                        {
                                            Console.WriteLine("DRAW!!\n\n");
                                            scoreDraw++;
                                            allDraws++;
                                        }
                                        else if (inputPlayer == "PAPER")
                                        {
                                            Console.WriteLine("PLAYER WINS!!\n\n");
                                            scorePlayer++;
                                            allUserWins++;
                                        }
                                        else if (inputPlayer == "SCISSORS")
                                        {
                                            Console.WriteLine("CPU WINS!!\n\n");
                                            scoreCPU++;
                                            allCpuWins++;
                                        }
                                        break;
                                    case 2:
                                        inputCPU = "PAPER";
                                        Console.WriteLine("Computer chose PAPER");
                                        if (inputPlayer == "PAPER")
                                        {
                                            Console.WriteLine("DRAW!!\n\n");
                                            scoreDraw++;
                                            allDraws++;
                                        }
                                        else if (inputPlayer == "ROCK")
                                        {
                                            Console.WriteLine("CPU WINS!!\n\n");
                                            scoreCPU++;
                                            allCpuWins++;
                                        }
                                        else if (inputPlayer == "SCISSORS")
                                        {
                                            Console.WriteLine("PLAYER WINS!!\n\n");
                                            scorePlayer++;
                                            allUserWins++;
                                        }
                                        break;
                                    case 3:
                                        inputCPU = "SCISSORS";
                                        Console.WriteLine("Computer chose SCISSORS");
                                        if (inputPlayer == "SCISSORS")
                                        {
                                            Console.WriteLine("DRAW!!\n\n");
                                            scoreDraw++;
                                            allDraws++;
                                        }
                                        else if (inputPlayer == "ROCK")
                                        {
                                            Console.WriteLine("PLAYER WINS!!\n\n");
                                            scorePlayer++;
                                            allUserWins++;
                                        }
                                        else if (inputPlayer == "PAPER")
                                        {
                                            Console.WriteLine("CPU WINS!!\n\n");
                                            scoreCPU++;
                                            allCpuWins++;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Invalid entry!");
                                        break;
                                }

                                Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}\tDRAW:\t{2}", scorePlayer, scoreCPU, scoreDraw);

                            }

                            if (scorePlayer == 3)
                            {
                                Console.WriteLine("Player WON!");
                            }
                            else if (scoreCPU == 3)
                            {
                                Console.WriteLine("CPU WON!");
                            }

                            Console.WriteLine("Do you want to play again?(y/n)");
                            string loop = Console.ReadLine();
                            if (loop == "y")
                            {
                                playAgain = true;
                                Console.Clear();
                            }
                            else if (loop == "n")
                            {
                                playAgain = false;
                            }
                            else
                            {

                            }

                        }

                        break;

                        //stats
                    case "2":
                        Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}\tDRAW:\t{2}", allUserWins, allCpuWins, allDraws);
                        double allGames = allUserWins + allCpuWins + allDraws;

                        double userWinsStats = allUserWins / allGames * 100;

                        double cpuWinsStats = allCpuWins / allGames * 100;

                        double drawStats = allDraws / allGames * 100;


                        Console.WriteLine($"User win percentage: {userWinsStats} \n Cpu win percentage: {cpuWinsStats} \n " +
                            $"Draws percentage {drawStats}");

                        Console.WriteLine("Press enter to return to main menu:");           
                        break;

                        //exit
                    case "3":
                        isRunning = false;
                        break;
                }

            }




           
        }
    }
}
