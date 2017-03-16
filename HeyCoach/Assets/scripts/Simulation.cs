using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simulation {

	public bool attack(Team a, Team b,int time, List<string> log_strings){
		//Debug.Log (a.shooting - b.defense);
		int pick = pickAttackPlayer();
		//Is it a steal?
		//yes steal the ball, change possession, use rebound formula, defense/2 with dribble to see if steal
		if (Steal(a.players [pick].dribble,b.players [pick].defense)) {
			string log_string = b.players [pick].Name + "看破" + a.players [pick].Name + "的进攻，抢断得手" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + time;
			Debug.Log (log_string);
			log_strings.Add (log_string);
			return true;
		}
		//Not a steal


		if ((a.players[pick].shooting - b.players[pick].defense) > Random.Range (0, 100)) {
			//add foul possibility 
			a.score = a.score + 2;
			string log_string = a.players [pick].Name + "单打" + b.players [pick].Name + "得分，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + time;
			Debug.Log (log_string);
			log_strings.Add (log_string);
			return true;//possession changed
		} 

		else {
			string log_string = a.players [pick].Name + "被" + b.players [pick].Name + "防下，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + time;
			Debug.Log (log_string);
			log_strings.Add (log_string);
			//Is it a block?
			//yes block the shot, posession 0.6 a possession 0.4 b possession
			//no is it a foul? 0.1 possibility
			//foul -- offesnive 0.2  off ball foul 0.4  shooting foul 0.4
			//no foul rebound --  35 35 10 10 10 possibility, 
			pick = pickReboundPlayer();
			if (Rebound (a.players [pick].rebound, b.players [pick].rebound) == true) {
				string log_string_1 = a.players [pick].Name + "在" + b.players [pick].Name + "头上怒摘进攻篮板，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + time;
				Debug.Log (log_string_1);
				log_strings.Add (log_string_1);
				return false;//possession unchanged
			}
			else {
				string log_string_2 = b.players [pick].Name + "卡在" + a.players [pick].Name + "身前拿下防守篮板，" + a.Name + a.score + ":" + b.Name + b.score + "剩余时间" + time;
				Debug.Log (log_string_2);
				log_strings.Add (log_string_2);
				return true;
			}
		}
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

	public bool Steal(int a,int b){
		b = b * 8;
		int ran = Random.Range(0,a+b);
		if (ran <= a)
			return true;
		else
			return false;

	}


	public Simulation ()
	{

	}

}
