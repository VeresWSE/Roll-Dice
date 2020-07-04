using System;
using static System.Console;

class MainClass
{
    public static void Main(string[] args)
    {


        Random rnd = new Random();
        int number = rnd.Next(1, 7);


        int[] numbers1 = new int[5];
        for (int i = 0; i < numbers1.Length; i++)
        {
            numbers1[i] = rnd.Next(1, 7);
        }
        int[] numbers2 = new int[5];
        for (int i = 0; i < numbers2.Length; i++)
        {
            numbers2[i] = rnd.Next(1, 7);
        }

        while (true)
        {
            Console.WriteLine("Player 1, press Enter to Roll&Dice!");
            var KeyCheck = ReadKey().Key;
            if (KeyCheck == ConsoleKey.Enter)
            {
                foreach (var nr in numbers1)
                {
                    Console.WriteLine(nr + " ");
                }
            }
            else
            {
                Console.WriteLine("Press correct key");
            }

            Console.WriteLine("Player 2, press Enter to Roll&Dice!");
            Console.ReadLine();
            if (KeyCheck == ConsoleKey.Enter)
            {
                foreach (var nr in numbers2)
                {
                    Console.WriteLine(nr + " ");
                }
            }
            else
            {
                Console.WriteLine("Press correct key");
            }

           



                WriteLine("Do you want to finish? [y]");
                string isExit = ReadLine();

                if (isExit == "y")
                {
                    break;
                }
                else
                {
                    Clear();
                    continue;
                }
            




            /*
                        string choiseOfThePlayerOne = ReadLine();
                        int choiseOfThePlayerOneInt;

                        while (!Int32.TryParse(choiseOfThePlayerOne, out choiseOfThePlayerOneInt)
                        || choiseOfThePlayerOneInt > 3
                        || choiseOfThePlayerOneInt <= 0)
                        {
                            WriteLine("Podaj poprawna liczbe");
                            choiseOfThePlayerOne = ReadLine();
                        }

                        WriteLine("[Gracz 2] Rzuć kośćmi");
                        string choiseOfThePlayerTwo = ReadLine();
                        int choiseOfThePlayerTwoInt;

                        while (!Int32.TryParse(choiseOfThePlayerTwo, out choiseOfThePlayerTwoInt)
                        || choiseOfThePlayerTwoInt > 3
                        || choiseOfThePlayerTwoInt <= 0)
                        {
                            WriteLine("Podaj poprawna liczbe");
                            choiseOfThePlayerTwo = ReadLine();
                        }

                        if (choiseOfThePlayerOne == choiseOfThePlayerTwo)
                        {
                            WriteLine("Remis");
                        }
                        else if ((choiseOfThePlayerOne == "1" && choiseOfThePlayerTwo == "3")
                        || (choiseOfThePlayerOne == "2" && choiseOfThePlayerTwo == "1")
                        || (choiseOfThePlayerOne == "3" && choiseOfThePlayerTwo == "2"))
                        {
                            WriteLine("Wygrywa pierwszy gracz");
                        }
                        else if ((choiseOfThePlayerOne == "3" && choiseOfThePlayerTwo == "1")
                        || (choiseOfThePlayerOne == "1" && choiseOfThePlayerTwo == "2")
                        || (choiseOfThePlayerOne == "2" && choiseOfThePlayerTwo == "3"))
                        {
                            WriteLine("Wygrywa drugi gracz");
                        }
                        WriteLine("czy chcesz zakonczyc żywot? [y]");
                        string isExit = ReadLine();

                        if (isExit == "y")
                        {
                            break;
                        }
                        Clear();
                        */
        }
    }
}