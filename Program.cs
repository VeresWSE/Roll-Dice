using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


class RollDice
{


    static int RollPlayerOneSum = 0;
    static int RollPlayerTwoSum = 0;

    static void MainMenuLoop()
    {
        GamesRecord gamesRecord = new GamesRecord(15);
        Player playerOne = new Player();
        Player playerTwo = new Player();
        ConsoleKeyInfo inputKey;
        do
        {
            Clear();
            WriteLine("Roll&Dice Menu:\n\t[1] Play game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
            inputKey = ReadKey(true);

            if (inputKey.Key == ConsoleKey.D1)
            {
                GameLoop(playerOne.playerName, playerTwo.playerName, gamesRecord);
            }
            else if (inputKey.Key == ConsoleKey.D2)
            {
                DisplayWelcomeMesssage();
            }
            else if (inputKey.Key == ConsoleKey.D3)
            {
                gamesRecord.WriteResult();
            }

        } while (inputKey.Key != ConsoleKey.Escape);

    }


    static void DisplayWelcomeMesssage()
    {
        WriteLine("No siema");
        WriteLine("Click any key to continue");
        ReadKey(true);
    }

    public static void Main(string[] args)
    {
        

        MainMenuLoop();
    }

    private static void GameLoop(string playerOneName, string playerTwoName, GamesRecord gamesRecord)
    {
        bool playGame = true;
        int[] numbers1 = new int[5];
        int[] numbers2 = new int[5];


            
            Random rnd = new Random();
            RollPlayerOneSum = 0;
            RollPlayerTwoSum = 0;

            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rnd.Next(1, 7);
                numbers2[i] = rnd.Next(1, 7);
            }

            WriteLine(playerOneName + ", press Enter to Roll&Dice!");
            while (ReadKey().Key != ConsoleKey.Enter)
            {
                WriteLine("Press correct key");
            }
            foreach (var nr in numbers1)
            {
                WriteLine(nr + " ");
            }
            WriteLine(playerTwoName + ", press Enter to Roll&Dice!");
            while (ReadKey().Key != ConsoleKey.Enter)
            {
                WriteLine("Press correct key");
            }
            foreach (var nr in numbers2)
            {
                WriteLine(nr + " ");
            }
            WriteLine("Press Enter to start round 2");


            while (ReadKey().Key != ConsoleKey.Enter)
            {
                WriteLine("Press correct key");
            }
            WriteLine(playerOneName + ", press A to re-roll dice 1 or press any other key to skip.");
            RerollPlayer(rnd, numbers1, ConsoleKey.A, 0);
            WriteLine(playerOneName + ", press S to re-roll dice 2 or press any other key to skip.");
            RerollPlayer(rnd, numbers1, ConsoleKey.S, 1);
            WriteLine(playerOneName + ", press D to re-roll dice 3 or press any other key to skip.");
            RerollPlayer(rnd, numbers1, ConsoleKey.D, 2);
            WriteLine(playerOneName + ", press F to re-roll dice 4 or press any other key to skip.");
            RerollPlayer(rnd, numbers1, ConsoleKey.F, 3);
            WriteLine(playerOneName + ", press G to re-roll dice 5 or press any other key to skip.");
            RerollPlayer(rnd, numbers1, ConsoleKey.G, 4);

            foreach (var nr in numbers1)
            {
                WriteLine(nr + " ");
            }
            WriteLine();
            WriteLine(playerTwoName + ", press A to re-roll dice 1 or press any other key to skip.");
            RerollPlayer(rnd, numbers2, ConsoleKey.A, 0);
            WriteLine(playerTwoName + ", press S to re-roll dice 2 or press any other key to skip.");
            RerollPlayer(rnd, numbers2, ConsoleKey.S, 1);
            WriteLine(playerTwoName + ", press D to re-roll dice 3 or press any other key to skip.");
            RerollPlayer(rnd, numbers2, ConsoleKey.D, 2);
            WriteLine(playerTwoName + ", press F to re-roll dice 4 or press any other key to skip.");
            RerollPlayer(rnd, numbers2, ConsoleKey.F, 3);
            WriteLine(playerTwoName + ", press G to re-roll dice 5 or press any other key to skip.");
            RerollPlayer(rnd, numbers2, ConsoleKey.G, 4);
            foreach (var nr in numbers2)
            {
                WriteLine(nr + " ");
            }


            for (int i = 0; i < numbers1.Length; i++)
            {
                RollPlayerOneSum += numbers1[i];
            }
            WriteLine(RollPlayerOneSum);
            for (int i = 0; i < numbers2.Length; i++)
            {
                RollPlayerTwoSum += numbers2[i];
            }
            WriteLine(RollPlayerTwoSum);
        gamesRecord.AddRecord(RollPlayerOneSum.ToString(), RollPlayerTwoSum.ToString(), DetermineWinner(playerOneName, playerTwoName));


        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Clear();
            GameLoop(playerOneName, playerTwoName, gamesRecord);
        }


        Clear();
        }
    

    

    private static string DetermineWinner(string playerOneName, string playerTwoName)
    {
        if (RollPlayerOneSum > RollPlayerTwoSum)
        {
            WriteLine(playerOneName + " wins");
            return playerOneName;
        }
        else if (RollPlayerOneSum < RollPlayerTwoSum)
        { 
            WriteLine(playerTwoName + " wins");
            return playerTwoName;
        }
        else
        {
            WriteLine("Draw");
            return "Draw";
        }
    }

    private static void RerollPlayer(Random rnd, int[] numbers, ConsoleKey key, int index)
    {
        if (ReadKey().Key == key)
        {
            numbers[index] = rnd.Next(1, 7);
            WriteLine();

        }
    }


}


