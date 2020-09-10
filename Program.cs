using System;
using System.Collections.Generic;
using static System.Console;

class RollDice
{

        public static void Main(string[] args)
        {
            Random rnd = new Random();

            bool playGame = true;
            int[] numbers1 = new int[5];
            int[] numbers2 = new int[5];

            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rnd.Next(1, 7);
                numbers2[i] = rnd.Next(1, 7);
            }

            while (playGame)
        {
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

                







            /*
            {
                int[] sorting1 = numbers1;
                for (int i = 0; i < sorting1.Length; i++)
                {
                    int count = 0;
                    for (int j = i; j < sorting1.Length; j++)
                    {
                        if (sorting1[j] == sorting1[i])
                            count = count + 1;
                    }
                    Console.WriteLine("\t\n " + sorting1[i] + "occurse" + count);
                    Console.ReadKey();
                }
            }
            /*
            {
                int[] sorting2 = numbers2;
                int count = 0;
                for (int i = 0; i < sorting2.Length; i++)
                {
                    for (int j = i; j < sorting2.Length - 1; j++)
                    {
                        if (sorting2[j] == sorting2[i])
                            count = count + 1;
                    }
                    Console.WriteLine("\t\n " + sorting2[i] + "occurse" + count);
                    Console.ReadKey();
                }
            }
            */

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

