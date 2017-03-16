using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Team
{
	public string Name;
	public int score;
	public Player player1 = new Player ();
	public Player player2 = new Player ();
	public Player player3 = new Player ();
	public Player player4 = new Player ();
	public Player player5 = new Player ();

	public Player[] players = new Player[5];
	//public int tactic   用数字代表第几种tactic
	//public int teamfoul;

	public Team (string n)
	{
		Name = n;
	}

	public bool shoot(Player a, Player b){
		//Debug.Log (a.shooting - b.defense);
		if (a.shooting - b.defense > Random.Range(0,100))
			return true;
		else
			return false;
	}

	public int pickAttackPlayer(){
		int ran = Random.Range(0,100);
		if (ran <= 20)
			return 0;
		else if (ran <= 40)
			return 1;
		else if (ran <= 60)
			return 2;
		else if (ran <= 80)
			return 3;
		else if (ran <= 100)
			return 4;
		else
			return 0;
	}

}


