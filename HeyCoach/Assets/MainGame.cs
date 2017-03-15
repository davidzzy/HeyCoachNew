using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class MainGame : MonoBehaviour {

	Player Aplayer1 = new Player();
	Player Aplayer2 = new Player();
	Player Aplayer3 = new Player();
	Player Aplayer4 = new Player();
	Player Aplayer5 = new Player();

	Player Bplayer1 = new Player();
	Player Bplayer2 = new Player();
	Player Bplayer3 = new Player();
	Player Bplayer4 = new Player();
	Player Bplayer5 = new Player();
	Simulation Sim = new Simulation ();

	Team team1 = new Team ("太原理工");
	Team team2 = new Team ("清华大学");
	 int time;
	 Random r = new Random ();
	 bool end;
	 bool possession; // true for a team to attack, false for b team to attack
	// Use this for initialization
	void Start () {
		
		Aplayer1.Name = "武正阳";
		Aplayer1.strenth = 90;
		Aplayer1.speed=90;
		Aplayer1.strenth=90;
		Aplayer1.jumping=90;
		Aplayer1.stamina=90;
		Aplayer1.fitness=90;
		Aplayer1.rebound=90;
		Aplayer1.dribble=90;
		Aplayer1.shooting=90;
		Aplayer1.pass=90;
		Aplayer1.defense=60;
		Aplayer1.position = 1;

		Aplayer2.Name = "朱真仪";
		Aplayer2.strenth = 90;
		Aplayer2.speed=90;
		Aplayer2.strenth=90;
		Aplayer2.jumping=90;
		Aplayer2.stamina=90;
		Aplayer2.fitness=90;
		Aplayer2.rebound=90;
		Aplayer2.dribble=90;
		Aplayer2.shooting=90;
		Aplayer2.pass=90;
		Aplayer2.defense=60;
		Aplayer2.position = 2;



		Aplayer3.Name = "乔丹";
		Aplayer3.strenth = 90;
		Aplayer3.speed=90;
		Aplayer3.strenth=90;
		Aplayer3.jumping=90;
		Aplayer3.stamina=90;
		Aplayer3.fitness=90;
		Aplayer3.rebound=90;
		Aplayer3.dribble=90;
		Aplayer3.shooting=90;
		Aplayer3.pass=90;
		Aplayer3.defense=60;
		Aplayer3.position = 3;


		Aplayer4.Name = "王洪";
		Aplayer4.strenth = 90;
		Aplayer4.speed=90;
		Aplayer4.strenth=90;
		Aplayer4.jumping=90;
		Aplayer4.stamina=90;
		Aplayer4.fitness=90;
		Aplayer4.rebound=90;
		Aplayer4.dribble=90;
		Aplayer4.shooting=90;
		Aplayer4.pass=90;
		Aplayer4.defense=60;
		Aplayer4.position = 4;


		Aplayer5.Name = "保罗";
		Aplayer5.strenth = 90;
		Aplayer5.speed=90;
		Aplayer5.strenth=90;
		Aplayer5.jumping=90;
		Aplayer5.stamina=90;
		Aplayer5.fitness=90;
		Aplayer5.rebound=90;
		Aplayer5.dribble=90;
		Aplayer5.shooting=90;
		Aplayer5.pass=90;
		Aplayer5.defense=60;
		Aplayer5.position = 5;

		Bplayer1.Name = "赤木刚宪";
		Bplayer1.strenth = 90;
		Bplayer1.speed=90;
		Bplayer1.strenth=90;
		Bplayer1.jumping=90;
		Bplayer1.stamina=90;
		Bplayer1.fitness=90;
		Bplayer1.rebound=90;
		Bplayer1.dribble=90;
		Bplayer1.shooting=90;
		Bplayer1.pass=90;
		Bplayer1.defense=60;
		Bplayer1.position = 1;

		Bplayer2.Name = "樱木花道";
		Bplayer2.strenth = 90;
		Bplayer2.speed=90;
		Bplayer2.strenth=90;
		Bplayer2.jumping=90;
		Bplayer2.stamina=90;
		Bplayer2.fitness=90;
		Bplayer2.rebound=90;
		Bplayer2.dribble=90;
		Bplayer2.shooting=90;
		Bplayer2.pass=90;
		Bplayer2.defense=60;
		Bplayer2.position = 2;



		Bplayer3.Name = "流川枫";
		Bplayer3.strenth = 90;
		Bplayer3.speed=90;
		Bplayer3.strenth=90;
		Bplayer3.jumping=90;
		Bplayer3.stamina=90;
		Bplayer3.fitness=90;
		Bplayer3.rebound=90;
		Bplayer3.dribble=90;
		Bplayer3.shooting=90;
		Bplayer3.pass=90;
		Bplayer3.defense=60;
		Bplayer3.position = 3;


		Bplayer4.Name = "三井寿";
		Bplayer4.strenth = 90;
		Bplayer4.speed=90;
		Bplayer4.strenth=90;
		Bplayer4.jumping=90;
		Bplayer4.stamina=90;
		Bplayer4.fitness=90;
		Bplayer4.rebound=90;
		Bplayer4.dribble=90;
		Bplayer4.shooting=90;
		Bplayer4.pass=90;
		Bplayer4.defense=60;
		Bplayer4.position = 4;


		Bplayer5.Name = "宫城良田";
		Bplayer5.strenth = 90;
		Bplayer5.speed=90;
		Bplayer5.strenth=90;
		Bplayer5.jumping=90;
		Bplayer5.stamina=90;
		Bplayer5.fitness=90;
		Bplayer5.rebound=90;
		Bplayer5.dribble=90;
		Bplayer5.shooting=90;
		Bplayer5.pass=90;
		Bplayer5.defense=60;
		Bplayer5.position = 5;

		team1.players[0] = Aplayer1;
		team1.players[1] = Aplayer2;
		team1.players[2] = Aplayer3;
		team1.players[3] = Aplayer4;
		team1.players[4] = Aplayer5;

		team2.players[0] = Bplayer1;
		team2.players[1] = Bplayer2;
		team2.players[2] = Bplayer3;
		team2.players[3] = Bplayer4;
		team2.players[4] = Bplayer5;

		team1.score = 0;

		time = 600;
		possession = true;
		Debug.Log("GameStart");
	}



	// Update is called once per frame
	void Update () {



		if (end != true) {
			time = time - Random.Range (8, 24);
			if (possession == true) {
				bool re = Sim.attack (team1, team2, time);
				if (re == true)
					possession = false;
			}

			else {
				bool re = Sim.attack (team2, team1, time);
				if (re == true)
					possession = true;
			}

			//Debug.Log (time);
			//yield return new WaitForSeconds (1);
			//action
		}
			

		if (time <= 0) {
			end = true;
			time = 600;
			Debug.Log ("单节结束！");
			return;
		}
	}
}
