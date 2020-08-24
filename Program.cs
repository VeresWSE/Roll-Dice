using System;
using static System.Console;

class MainClass
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

            WriteLine("Do you want to finish? [y]");

            if (ReadKey().Key == ConsoleKey.Y)
            {
                playGame = false;
            }

            Clear();
        }
    }
}