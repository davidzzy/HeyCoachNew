using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour {
	public GameObject logPanel;
	public GameObject scorePanel;
	public GameObject statsPanel;
	Text logText;
	Text scoreText;
	Text statsText;
	List<string> log_strings;

	const int NUM_DISPLAY_LINES = 20;

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
	GameState state;

	Team team1 = new Team ("开雾大讲堂");
	Team team2 = new Team ("湘北");
	 int time;
	 //Random r = new Random ();
	 bool end;
	 bool possession; // true for a team to attack, false for b team to attack
	// Use this for initialization
	void Start () {
		Debug.Log (PlayerGeneration.Center.Name);
		logText = logPanel.GetComponent<Text> ();
		scoreText = scorePanel.GetComponent<Text> ();
		statsText = statsPanel.GetComponent<Text> ();
		log_strings = new List<string> ();

//		Aplayer1.Name = "大哥";
//		Aplayer1.speed=90;
//		Aplayer1.strenth=90;
//		Aplayer1.jumping=90;
//		Aplayer1.stamina=90;
//		Aplayer1.fitness=90;
//		Aplayer1.rebound=90;
//		Aplayer1.dribble=90;
//		Aplayer1.shooting=75;
//		Aplayer1.pass=60;
//		Aplayer1.defense=60;
//		Aplayer1.position = 1;
//		Aplayer1.fouls = 0;
		Aplayer1 = PlayerGeneration.Center;

//		Aplayer2.Name = "单神";
//		Aplayer2.speed=90;
//		Aplayer2.strenth=90;
//		Aplayer2.jumping=90;
//		Aplayer2.stamina=90;
//		Aplayer2.fitness=90;
//		Aplayer2.rebound=90;
//		Aplayer2.dribble=90;
//		Aplayer2.shooting=75;
//		Aplayer2.pass=60;
//		Aplayer2.defense=60;
//		Aplayer2.position = 2;
//		Aplayer2.fouls = 0;
		Aplayer2 = PlayerGeneration.PowerForward;

//		Aplayer3.Name = "大佬T";
//		Aplayer3.speed=90;
//		Aplayer3.strenth=90;
//		Aplayer3.jumping=90;
//		Aplayer3.stamina=90;
//		Aplayer3.fitness=90;
//		Aplayer3.rebound=90;
//		Aplayer3.dribble=90;
//		Aplayer3.shooting=90;
//		Aplayer3.pass=60;
//		Aplayer3.defense=60;
//		Aplayer3.position = 3;
//		Aplayer3.fouls = 0;
		Aplayer3 = PlayerGeneration.SmallForward;

//		Aplayer4.Name = "阿博";
//		Aplayer4.speed=90;
//		Aplayer4.strenth=90;
//		Aplayer4.jumping=90;
//		Aplayer4.stamina=90;
//		Aplayer4.fitness=90;
//		Aplayer4.rebound=90;
//		Aplayer4.dribble=90;
//		Aplayer4.shooting=90;
//		Aplayer4.pass=60;
//		Aplayer4.defense=60;
//		Aplayer4.position = 4;
//		Aplayer4.fouls = 0;
		Aplayer4 = PlayerGeneration.ShootingGuard;

//		Aplayer5.Name = "猪猪";
//		Aplayer5.speed=90;
//		Aplayer5.strenth=90;
//		Aplayer5.jumping=90;
//		Aplayer5.stamina=90;
//		Aplayer5.fitness=90;
//		Aplayer5.rebound=90;
//		Aplayer5.dribble=90;
//		Aplayer5.shooting=75;
//		Aplayer5.pass = 90;
//		Aplayer5.defense=60;
//		Aplayer5.position = 5;
//		Aplayer5.fouls = 0;
		Aplayer5 = PlayerGeneration.PointGuard;


		Bplayer1.Name = "赤木刚宪";
		Bplayer1.speed=90;
		Bplayer1.strenth=90;
		Bplayer1.jumping=90;
		Bplayer1.stamina=90;
		Bplayer1.fitness=90;
		Bplayer1.rebound=90;
		Bplayer1.dribble=90;
		Bplayer1.shooting=75;
		Bplayer1.pass=60;
		Bplayer1.defense=60;
		Bplayer1.position = 1;
		Bplayer1.fouls = 0;


		Bplayer2.Name = "樱木花道";
		Bplayer2.speed=90;
		Bplayer2.strenth=90;
		Bplayer2.jumping=90;
		Bplayer2.stamina=90;
		Bplayer2.fitness=90;
		Bplayer2.rebound=90;
		Bplayer2.dribble=90;
		Bplayer2.shooting=75;
		Bplayer2.pass=60;
		Bplayer2.defense=60;
		Bplayer2.position = 2;
		Bplayer2.fouls = 0;



		Bplayer3.Name = "流川枫";
		Bplayer3.speed=90;
		Bplayer3.strenth=90;
		Bplayer3.jumping=90;
		Bplayer3.stamina=90;
		Bplayer3.fitness=90;
		Bplayer3.rebound=90;
		Bplayer3.dribble=90;
		Bplayer3.shooting=90;
		Bplayer3.pass=60;
		Bplayer3.defense=60;
		Bplayer3.position = 3;
		Bplayer3.fouls = 0;


		Bplayer4.Name = "三井寿";
		Bplayer4.speed=90;
		Bplayer4.strenth=90;
		Bplayer4.jumping=90;
		Bplayer4.stamina=90;
		Bplayer4.fitness=90;
		Bplayer4.rebound=90;
		Bplayer4.dribble=90;
		Bplayer4.shooting=90;
		Bplayer4.pass=60;
		Bplayer4.defense=60;
		Bplayer4.position = 4;
		Bplayer4.fouls = 0;



		Bplayer5.Name = "宫城良田";
		Bplayer5.speed=90;
		Bplayer5.strenth=90;
		Bplayer5.jumping=90;
		Bplayer5.stamina=90;
		Bplayer5.fitness=90;
		Bplayer5.rebound=90;
		Bplayer5.dribble=90;
		Bplayer5.shooting=75;
		Bplayer5.pass=90;
		Bplayer5.defense=60;
		Bplayer5.position = 5;
		Bplayer5.fouls = 0;


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
		team1.teamfoul = 0;
		team2.score = 0;
		team2.teamfoul = 0;
		time = 600;
		possession = true;
		state = new GameState (team1, team2);
		Debug.Log("GameStart");
	}



	// Update is called once per frame
	void Update () {



		if (end != true) {
			time = time - Random.Range (8, 24);
			if (possession == true) {
				bool re = Sim.attack (state.teamA, state.teamB, time, log_strings,state);
				if (state.possession == true)
					possession = false;
			}

			else {
				bool re = Sim.attack (state.teamB, state.teamA, time, log_strings,state);
				if (state.possession == true)
					possession = true;
			}

			logText.text = "";
			for (int i = 0; i < log_strings.Count; i++) {
				logText.text += log_strings[i] + "\n";
			}

			//Debug.Log (time);
			//yield return new WaitForSeconds (1);
			//action
		}

		scoreText.text = "Team 1: " + state.teamA.score + "  :  " + state.teamB.score + " :Team 2";
			
		statsText.text = "球员, 得分, 篮板, 助攻, 抢断, 盖帽, 失误, 犯规\n";
		for(int i=0; i < 5;i++)
			statsText.text += state.teamA.players[i].Name + " " + state.teamA.players[i].points + " " + state.teamA.players[i].rebounds + " " + state.teamA.players[i].assists + " " + state.teamA.players[i].steals + " " + state.teamA.players[i].blocks + " " + state.teamA.players[i].turnovers + " " + state.teamA.players[i].fouls + "\n";
		statsText.text += "\n\n球员, 得分, 篮板, 助攻, 抢断, 盖帽, 失误, 犯规\n";
		for(int i=0; i < 5;i++)
			statsText.text += state.teamB.players[i].Name + " " + state.teamB.players[i].points + " " + state.teamB.players[i].rebounds + " " + state.teamB.players[i].assists + " " + state.teamB.players[i].steals + " " + state.teamB.players[i].blocks + " " + state.teamB.players[i].turnovers + " " + state.teamB.players[i].fouls + "\n";

		if (time <= 0) {
			end = true;
			time = 600;
			Debug.Log ("单节结束！");
			return;
		}
	}
}
