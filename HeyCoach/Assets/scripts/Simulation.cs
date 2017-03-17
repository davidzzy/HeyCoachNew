using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simulation {
	
	public bool attack(Team a, Team b,int time, List<string> log_strings, GameState state){
		//Debug.Log (a.shooting - b.defense);
		int pick = pickAttackPlayer();
		string timer = Timer (time);
		//Is it a steal?
		//yes steal the ball, change possession, use rebound formula, defense/2 with dribble to see if steal
		if (Steal(a.players [pick].dribble,b.players [pick].defense)) {
			string log_string = b.players [pick].Name + "看破" + a.players [pick].Name + "的进攻，抢断得手" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
			Debug.Log (log_string);
			log_strings.Add (log_string);

			state.possession = true;
			return true;
		}
		//Not a steal
		//Is it a foul?
		if (Random.Range (1, 10) == 1) { // 0.1 chance result in a foul
			b.players[pick].foul++;
			string log_string = b.players [pick].Name + "抢断" + a.players [pick].Name + "打手，" + b.players [pick].Name + b.players[pick].foul + "次犯规," +
				a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
			Debug.Log (log_string);
			log_strings.Add (log_string);

			state.possession = true;
			return true;
		}

		//Is it a score?
		if ((a.players[pick].shooting + a.players[pick].dribble - b.players[pick].defense*2) > Random.Range (0, 100)) {
			//add shooting foul possibility 
			if (pick > 2 && Random.Range (1, 10) <= 4) { //SF SG PG has 0.4 chance for a make 3
				a.score = a.score + 3;
				string log_string_5 = a.players [pick].Name + "面对" + b.players [pick].Name + "防守彪中三分，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				if (Random.Range (1, 10) == 1) {
					b.players[pick].foul++;
					log_string_5 += "\n" + "同时造成对方犯规,"+ b.players [pick].Name + b.players[pick].foul + "次犯规,";
					if (FreeThrow (a.players [pick].shooting) == 1) {
						a.score++;
						log_string_5 += "\n" + a.players [pick].Name + "加罚命中" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
					} 
					else {
						log_string_5 += "\n" + a.players [pick].Name + "加罚不中" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
					}
						

				}

				Debug.Log (log_string_5);
				log_strings.Add (log_string_5);

				state.possession = true;
				return true;
			}
			a.score = a.score + 2;
			string log_string = a.players [pick].Name + "单打" + b.players [pick].Name + "得分，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
			if (Random.Range (1, 10) == 1) {
				b.players[pick].foul++;
				log_string += "\n" + "同时造成对方犯规,"+ b.players [pick].Name + b.players[pick].foul + "次犯规,";
				if (FreeThrow (a.players [pick].shooting) == 1) {
					a.score++;
					log_string += "\n" + a.players [pick].Name + "加罚命中" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				} 
				else {
					log_string += "\n" + a.players [pick].Name + "加罚不中" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				}


			}


			Debug.Log (log_string);
			log_strings.Add (log_string);

			state.possession = true;
			return true;//possession changed
		} 

		else {
			if (Block (a.players [pick].jumping, b.players [pick].defense)) {
				string log_string_3 = b.players [pick].Name + "将" + a.players [pick].Name + "的投篮扇飞," + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				Debug.Log (log_string_3);
				log_strings.Add (log_string_3);
				if (Random.Range (1, 10) < 5) {
					string log_string_4 = b.Name + "得到球权";
					Debug.Log (log_string_3);
					log_strings.Add (log_string_3);

					state.possession = true;
					return true;
				} else {
					string log_string_4 = a.Name + "得到球权,继续进攻";
					Debug.Log (log_string_4);
					log_strings.Add (log_string_4);
					//possession unchanged
					state.possession = false;
					return false;
				}


			}
			//Is it a block?
			//yes block the shot, posession 0.6 a possession 0.4 b possession

			if (Random.Range (1, 10) == 1) {
				b.players[pick].foul++;
				string log_string_6 = b.players [pick].Name + "封盖" + a.players [pick].Name + "时打手，" + b.players [pick].Name + b.players[pick].foul + "次犯规," +
					a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				if (FreeThrow (a.players [pick].shooting) == 1) {
					a.score++;
					log_string_6 += "\n" + a.players [pick].Name + "罚球命中" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				} 
				else {
					log_string_6 += "\n" + a.players [pick].Name + "罚球不中" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				}

				if (FreeThrow (a.players [pick].shooting) == 1) {
					a.score++;
					log_string_6 += "\n" + a.players [pick].Name + "罚球命中" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				} 
				else {
					log_string_6 += "\n" + a.players [pick].Name + "罚球不中" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				}

				Debug.Log (log_string_6);
				log_strings.Add (log_string_6);

				state.possession = true;
				return true;

			}


			//no is it a foul? 0.1 possibility
			//foul -- shooting foul 
			//no foul rebound --  35 35 10 10 10 possibility, 

			string log_string = a.players [pick].Name + "被" + b.players [pick].Name + "防下，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
			Debug.Log (log_string);
			log_strings.Add (log_string);

			pick = pickReboundPlayer();
			if (Rebound (a.players [pick].rebound, b.players [pick].rebound) == true) {
				string log_string_1 = a.players [pick].Name + "在" + b.players [pick].Name + "头上怒摘进攻篮板，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				Debug.Log (log_string_1);
				log_strings.Add (log_string_1);

				state.possession = false;
				return false;//possession unchanged
			}
			else {
				string log_string_2 = b.players [pick].Name + "卡在" + a.players [pick].Name + "身前拿下防守篮板，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + timer;
				Debug.Log (log_string_2);
				log_strings.Add (log_string_2);

				state.possession = true;
				return true;
			}
		}
	}

	public void checkFoul(){
		//check if anyplayer fouled out, happen after attack method

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

	public int pickReboundPlayer(){
		int ran = Random.Range(0,100);
		if (ran <= 35)
			return 0;
		else if (ran <= 70)
			return 1;
		else if (ran <= 80)
			return 2;
		else if (ran <= 90)
			return 3;
		else if (ran <= 100)
			return 4;
		else
			return 0;
	}
	//offensive rebound a , defensive rebound b, a is less possible to get offesnive rebound 
	public bool Rebound(int a,int b){
		a = a / 2;
		int ran = Random.Range(0,a+b);
		if (ran <= a)
			return true;
		else
			return false;
	}
	// jumping b, defense a, 
	public bool Block(int a,int b){
		b = b * 20;
		int ran = Random.Range (0, a + b);
		if (ran <= a)
			return true;
		else
			return false;
	}

	public bool Steal(int a,int b){
		b = b * 8;
		int ran = Random.Range(0,a+b);
		if (ran <= a)
			return true;
		else
			return false;

	}


	public int FreeThrow(int a){
		if (a > Random.Range (0, 100))
			return 1;
		return 0;
	}

	public string Timer(int timer){
		int minutes = Mathf.FloorToInt(timer / 60F);
		int seconds = Mathf.FloorToInt(timer - minutes * 60);
		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
		return niceTime;
	}

	public Simulation ()
	{

	}

}
