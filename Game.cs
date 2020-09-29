using System;
using static System.Console;

public class Game : AbstractGame
{
    GamesRecord gamesRecord;
    Player playerOne;
    Player playerTwo;

    public Game()
    {
        gamesRecord = new GamesRecord(10);
        playerOne = new Player();
        playerTwo = new Player();
        MainMenuLoop();
    }
    void DisplayWelcomeMesssage()
    {
        WriteLine("Hello there! Welcome to Retarded Roll&Dice! Rules are very easy: player, who has more points after two rounds, wins." +
            " If you are not satisfied after first roll, you can re-roll separated dices. Good luck!");
        WriteLine("Click any key to continue");
        ReadKey(true);
    }
    int RollPlayerOneSum = 0;
    int RollPlayerTwoSum = 0;

    protected override void MainMenuLoop()
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
        Clear();
        WriteLine(playerOne.PlayerName + ", press Enter to Roll&Dice!");
        while (ReadKey().Key != ConsoleKey.Enter)
        {
            WriteLine("Press correct key");
        }
        foreach (var nr in numbers1)
        {
            Write(nr + " ");
        }
        WriteLine();
        WriteLine(playerTwo.PlayerName + ", press Enter to Roll&Dice!");
        while (ReadKey().Key != ConsoleKey.Enter)
        {
            WriteLine("Press correct key");
        }
        foreach (var nr in numbers2)
        {
            Write(nr + " ");
        }
        WriteLine();

        WriteLine("Press Enter to start round 2");


        while (ReadKey().Key != ConsoleKey.Enter)
        {
            WriteLine("Press correct key");
        }

        WriteLine(playerOne.PlayerName + ", press 1 to re-roll dice 1 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.D1, 0);
        WriteLine(playerOne.PlayerName + ", press 2 to re-roll dice 2 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.D2, 1);
        WriteLine(playerOne.PlayerName + ", press 3 to re-roll dice 3 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.D3, 2);
        WriteLine(playerOne.PlayerName + ", press 4 to re-roll dice 4 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.D4, 3);
        WriteLine(playerOne.PlayerName + ", press 5 to re-roll dice 5 or press any other key to skip.");
        RerollPlayer(rnd, numbers1, ConsoleKey.D5, 4);
        WriteLine();
        
        foreach (var nr in numbers1)
        {
            Write(nr + " ");
        }
        WriteLine();
        WriteLine(playerTwo.PlayerName + ", press 1 to re-roll dice 1 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.D1, 0);
        WriteLine(playerTwo.PlayerName + ", press 2 to re-roll dice 2 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.D2, 1);
        WriteLine(playerTwo.PlayerName + ", press 3 to re-roll dice 3 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.D3, 2);
        WriteLine(playerTwo.PlayerName + ", press 4 to re-roll dice 4 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.D4, 3);
        WriteLine(playerTwo.PlayerName + ", press 5 to re-roll dice 5 or press any other key to skip.");
        RerollPlayer(rnd, numbers2, ConsoleKey.D5, 4);
        WriteLine();

        foreach (var nr in numbers2)
        {
            Write(nr + " ");
        }
        WriteLine();
        WriteLine("Press Enter to see results");
        while (ReadKey().Key != ConsoleKey.Enter)
        {
            WriteLine("Press correct key");
        }

        Clear();

        for (int i = 0; i < numbers1.Length; i++)
        {
            RollPlayerOneSum += numbers1[i];
        }
        WriteLine();
        WriteLine(RollPlayerOneSum);
        for (int i = 0; i < numbers2.Length; i++)
        {
            RollPlayerTwoSum += numbers2[i];
        }
        WriteLine(RollPlayerTwoSum);

        gamesRecord.AddRecord(new Record(RollPlayerOneSum.ToString(), RollPlayerTwoSum.ToString(), DetermineWinner()));

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
            WriteLine(playerOne.PlayerName + " wins");
            return playerOne.PlayerName;
        }
        else if (RollPlayerOneSum < RollPlayerTwoSum)
        {
            WriteLine(playerTwo.PlayerName + " wins");
            return playerTwo.PlayerName;
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
