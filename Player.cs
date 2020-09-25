using System;
using static System.Console;
public class Player
{
	protected string playerName;

	public string PlayerName
	{
		get
		{
			return playerName;
		}
		set
		{
			playerName = value;
		}
	}

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
		PlayerName = ReadLine();
	}

}
