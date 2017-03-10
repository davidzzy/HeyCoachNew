using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class MainGame : MonoBehaviour {

	public Player player1 = new Player("WuZhengYang","PF");

	public Team team1 = new Team ("TaiYuanLiGong");

	public int time;
	public Random r = new Random ();
	public bool end;
	public bool possession; // true for a team to attack, false for b team to attack
	// Use this for initialization
	void Start () {
		
		player1.strenth = 90;
		player1.speed=90;
		player1.strenth=90;
		player1.jumping=90;
		player1.stamina=90;
		player1.fitness=90;
		player1.rebound=90;
		player1.dribble=90;
		player1.shooting=90;
		player1.pass=90;
		player1.defense=90;

		team1.score = 0;

		time = 600;

	}



	// Update is called once per frame
	void Update () {



		if (end != true) {
			time = time - r.next (8, 24);
			//action
		}
			

		if (time == 0) {
			end = true;
			break;
		}
	}
}
