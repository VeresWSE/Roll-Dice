using System;

public class Record : IGameRecord
{
	string playerOneChoice;
	string playerTwoChoice;
	string result;

    public Record(string playerOneChoice, string playerTwoChoice, string result)
    {
        this.playerOneChoice = playerOneChoice;
        this.playerTwoChoice = playerTwoChoice;
        this.result = result;
    }
    override public string ToString()
    {
        return string.Format("{0,20} : {1,-20}", playerOneChoice + " vs " + playerTwoChoice, result);
    }

}
