using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


class RollDice
{
    static void DisplayWelcomeMesssage()
    {
        WriteLine("No siema");
    }
    public static void Main(string[] args)
    {
        int gamesRecordSize = 10;
        string[,] gamesRecord = new string[gamesRecordSize, 3];
        int GamesRecordCurrentIndex = (GamesRecordCurrentIndex = 0) % gamesRecordSize;


        bool playGame = true;
        int[] numbers1 = new int[5];
        int[] numbers2 = new int[5];

        DisplayWelcomeMesssage();

        while (playGame)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rnd.Next(1, 7);
                numbers2[i] = rnd.Next(1, 7);
            }

            WriteLine("Player 1, press Enter to Roll&Dice!");
            while (ReadKey().Key != ConsoleKey.Enter)
            {
                WriteLine("Press correct key");
            }
            foreach (var nr in numbers1)
            {
                WriteLine(nr + " ");
            }
            WriteLine("Player 2, press Enter to Roll&Dice!");
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
            WriteLine("Player 1, press A to re-roll dice 1 or press any other key to skip.");
            RerollPlayer1(rnd, numbers1, ConsoleKey.A, 0);
            WriteLine("Player 1, press S to re-roll dice 2 or press any other key to skip.");
            RerollPlayer1(rnd, numbers1, ConsoleKey.S, 1);
            WriteLine("Player 1, press D to re-roll dice 3 or press any other key to skip.");
            RerollPlayer1(rnd, numbers1, ConsoleKey.D, 2);
            WriteLine("Player 1, press F to re-roll dice 4 or press any other key to skip.");
            RerollPlayer1(rnd, numbers1, ConsoleKey.F, 3);
            WriteLine("Player 1, press G to re-roll dice 5 or press any other key to skip.");
            RerollPlayer1(rnd, numbers1, ConsoleKey.G, 4);

            foreach (var nr in numbers1)
            {
                WriteLine(nr + " ");
            }
            WriteLine();
            WriteLine("Player 2, press A to re-roll dice 1 or press any other key to skip.");
            RerollPlayer2(rnd, numbers2, ConsoleKey.A, 0);
            WriteLine("Player 2, press S to re-roll dice 2 or press any other key to skip.");
            RerollPlayer2(rnd, numbers2, ConsoleKey.S, 1);
            WriteLine("Player 2, press D to re-roll dice 3 or press any other key to skip.");
            RerollPlayer2(rnd, numbers2, ConsoleKey.D, 2);
            WriteLine("Player 2, press F to re-roll dice 4 or press any other key to skip.");
            RerollPlayer2(rnd, numbers2, ConsoleKey.F, 3);
            WriteLine("Player 2, press G to re-roll dice 5 or press any other key to skip.");
            RerollPlayer2(rnd, numbers2, ConsoleKey.G, 4);
            foreach (var nr in numbers2)
            {
                WriteLine(nr + " ");
            }

                int RollPlayerOneSum = 0;
                int RollPlayerTwoSum = 0;
                for (int i = 0; i < numbers1.Length; i++)
                {
                    RollPlayerOneSum += numbers1[i];
                }
                WriteLine(RollPlayerOneSum);
            gamesRecord[GamesRecordCurrentIndex, 0] = RollPlayerOneSum.ToString();
            for (int i = 0; i < numbers2.Length; i++)
            {
                RollPlayerTwoSum += numbers2[i];
            }
            WriteLine(RollPlayerTwoSum);
            gamesRecord[GamesRecordCurrentIndex, 1] = RollPlayerTwoSum.ToString();

            if (RollPlayerOneSum > RollPlayerTwoSum)
            {
                gamesRecord[GamesRecordCurrentIndex, 2] = "Player 1";
                WriteLine("Player 1 wins");
            }
            else if (RollPlayerOneSum<RollPlayerTwoSum)
            {
                gamesRecord[GamesRecordCurrentIndex, 2] = "Player 2";
                WriteLine("Player 2 wins");
            }
            else
            {
                gamesRecord[GamesRecordCurrentIndex, 2] = "Draw";
                WriteLine("Draw");
            }


           GamesRecordCurrentIndex += 1;


            WriteLine("Results");
            for (int i=0; i<GamesRecordCurrentIndex; i++)
            {
                WriteLine("Game #{0}: {1} - {2}, won {3}", i + 1, gamesRecord[i, 0], gamesRecord[i, 1], gamesRecord[i, 2]);
            }


            WriteLine("Do you want to finish? [y]");

            if (ReadKey().Key == ConsoleKey.Y)
            {
                playGame = false;
            }

            Clear();
        }
    }



    private static void RerollPlayer2(Random rnd, int[] numbers2, ConsoleKey key, int index)
{
    if (ReadKey().Key == key)
    {
        numbers2[index] = rnd.Next(1, 7);
        WriteLine();

    }
}

private static void RerollPlayer1(Random rnd, int[] numbers1, ConsoleKey key, int index)
{
    if (ReadKey().Key == key)
    {
        numbers1[index] = rnd.Next(1, 7);
        WriteLine();

    }
}
}

