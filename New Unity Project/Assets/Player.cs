using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int speed;
	public int strenth;
	public int jumping;
	public int stamina;
	public int fitness;

	public int rebound;
	public int dribble;
	public int shooting;
	public int pass;
	public int defense;

	public int height;
	public int weight;

	public string name;
	public string position;
	// Use this for initialization
	public Player (string n, string p)
	{
		name = n;
		position = p;
	}
}


速度：影响突破系数，影响外线防守成功率，与身高体重比相关
力量：影响篮板成功率，影响内线防守成功率,影响掩护质量，与身高体重比相关
弹跳：影响篮板成功率，影响盖帽成功率
耐力：影响体力消耗速度，体力恢复速度
体质：（影响受伤倾向和受伤恢复时间，--需要优质训练环境才能提高）

技术数值影响
篮板：影响篮板成功率
运球：影响突破成功率，影响对方抢断成功率
投篮：影响投篮成功率
传球：影响队友投篮成功率，（高传球人传给队友有投篮加成，因为队友容易是空位）
防守：影响盖帽、抢断成功率，影响对方投篮成功率