using System;

public class GamesRecord
{
    int gamesRecordSize;
    string[,] gamesRecord;
    int GamesRecordCurrentIndex;
    public GamesRecord(int recordSize = 10)
    {
        gamesRecordSize = recordSize;
        gamesRecord = new string[gamesRecordSize, 3];
        GamesRecordCurrentIndex = 0;

    }
}
