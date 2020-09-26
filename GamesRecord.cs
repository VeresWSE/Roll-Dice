using System;
using static System.Console;
public class GamesRecord
{
    int gamesRecordSize;
    IGameRecord[] gamesRecord;
    int gamesRecordCurrentIndex;
    public GamesRecord(int recordSize = 10)
    {
        try
        {
            gamesRecordSize = recordSize;
            gamesRecord = new IGameRecord[gamesRecordSize];
        }
        catch (OverflowException e)
        {
            WriteLine("OverflowException during GamesRecord initialization: \"{0}\"\nrecordSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
            gamesRecordSize = 10;
            gamesRecord = new IGameRecord[gamesRecordSize];
        }

        gamesRecordCurrentIndex = 0;

    }
    public void AddRecord(IGameRecord record)
    {
        gamesRecord[gamesRecordCurrentIndex] = record;

        gamesRecordCurrentIndex++;
        gamesRecordCurrentIndex = gamesRecordCurrentIndex % gamesRecordSize;
    }
    public void WriteResult()
    {
        WriteLine("Results");
        for (int i = 0; i < gamesRecordCurrentIndex; i++)
        {
            WriteLine("Game #{0}:\t{1}", i + 1, gamesRecord[i].ToString());
        }
        WriteLine("Click any key to continue");
        ReadKey(true);
    }
}
