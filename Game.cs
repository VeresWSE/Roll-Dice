﻿using System;
using static System.Console;

public class Game
{
	GamesRecord gamesRecord;
	Player playerOne;
	Player playerTwo;

	public Game()
	{
		gamesRecord = new GamesRecord(15);
		playerOne = new Player();
		playerTwo = new Player();
        MainMenuLoop();
    }
	void DisplayWelcomeMesssage()
	{
		WriteLine("No siema");
		WriteLine("Click any key to continue");
		ReadKey(true);
	}
    int RollPlayerOneSum = 0;
    int RollPlayerTwoSum = 0;

    void MainMenuLoop()
    {

        ConsoleKeyInfo inputKey;
        do
        {
            Clear();
            WriteLine("Roll&Dice Menu:\n\t[1] Play game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
            inputKey = ReadKey(true);

            if (inputKey.Key == ConsoleKey.D1)
            {
                GameLoop();
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
    void GameLoop()
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

        WriteLine(playerOne.playerName + ", press Enter to Roll&Dice!");
        while (ReadKey().Key != ConsoleKey.Enter)
        {
            WriteLine("Press correct key");
        }
        foreach (var nr in numbers1)
        {
            WriteLine(nr + " ");
        }
        WriteLine(playerTwo.playerName + ", press Enter to Roll&Dice!");
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
        WriteLine(playerOne.playerName + ", press A to re-roll dice 1 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.A, 0);
        WriteLine(playerOne.playerName + ", press S to re-roll dice 2 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.S, 1);
        WriteLine(playerOne.playerName + ", press D to re-roll dice 3 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.D, 2);
        WriteLine(playerOne.playerName + ", press F to re-roll dice 4 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.F, 3);
        WriteLine(playerOne.playerName + ", press G to re-roll dice 5 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.G, 4);

        foreach (var nr in numbers1)
        {
            WriteLine(nr + " ");
        }
        WriteLine();
        WriteLine(playerTwo.playerName + ", press A to re-roll dice 1 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.A, 0);
        WriteLine(playerTwo.playerName + ", press S to re-roll dice 2 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.S, 1);
        WriteLine(playerTwo.playerName + ", press D to re-roll dice 3 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.D, 2);
        WriteLine(playerTwo.playerName + ", press F to re-roll dice 4 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.F, 3);
        WriteLine(playerTwo.playerName + ", press G to re-roll dice 5 or press any other key to skip.");
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
        gamesRecord.AddRecord(RollPlayerOneSum.ToString(), RollPlayerTwoSum.ToString(), DetermineWinner());

        WriteLine("Do you want to play another round? [y]");
        if (ReadKey(true).Key == ConsoleKey.Y)
        {
            Clear();
            GameLoop();
        }


        Clear();
    }
    string DetermineWinner()
    {
        if (RollPlayerOneSum > RollPlayerTwoSum)
        {
            WriteLine(playerOne.playerName + " wins");
            return playerOne.playerName;
        }
        else if (RollPlayerOneSum < RollPlayerTwoSum)
        {
            WriteLine(playerTwo.playerName + " wins");
            return playerTwo.playerName;
        }
        else
        {
            WriteLine("Draw");
            return "Draw";
        }
    }

    void RerollPlayer(Random rnd, int[] numbers, ConsoleKey key, int index)
    {
        if (ReadKey().Key == key)
        {
            numbers[index] = rnd.Next(1, 7);
            WriteLine();

        }
    }

}
