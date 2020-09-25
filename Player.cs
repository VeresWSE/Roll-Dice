using System;
using static System.Console;
public class Player
{
	public string playerName;
	public Player(string playerName)
	{
		this.playerName = playerName;
	}
	public Player()
	{
		SetPlayerName();
	}

	public void SetPlayerName()
	{
		Write("Please enter player name: ");
		playerName = ReadLine();
	}

}
