using System;
using static System.Console;
public class GamesRecord
{
    int gamesRecordSize;
    string[,] gamesRecord;
    int gamesRecordCurrentIndex;
    public GamesRecord(int recordSize = 10)
    {
        try
        {
            gamesRecordSize = recordSize;
            gamesRecord = new string[gamesRecordSize, 3];
        }
        catch (OverflowException e)
        {
            WriteLine("OverflowException during GamesRecord initialization: \"{0}\"\nrecordSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
            gamesRecordSize = 10;
            gamesRecord = new string[gamesRecordSize, 3];
        }

        gamesRecordCurrentIndex = 0;

    }
    public void AddRecord(string playerOneChoice, string playerTwoChoice, string result)
    {
        gamesRecord[gamesRecordCurrentIndex, 0] = playerOneChoice;
        gamesRecord[gamesRecordCurrentIndex, 1] = playerTwoChoice;
        gamesRecord[gamesRecordCurrentIndex, 2] = result;
        gamesRecordCurrentIndex++;
        gamesRecordCurrentIndex = gamesRecordCurrentIndex % gamesRecordSize;
    }
    public void WriteResult()
    {
        WriteLine("Results");
        for (int i = 0; i < gamesRecordCurrentIndex; i++)
        {
            WriteLine("Game #{0}: {1} - {2}, won {3}", i + 1, gamesRecord[i, 0], gamesRecord[i, 1], gamesRecord[i, 2]);
        }
        WriteLine("Click any key to continue");
        ReadKey(true);
    }
}
