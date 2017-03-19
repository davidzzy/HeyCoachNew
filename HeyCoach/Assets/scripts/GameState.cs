﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState  {

	public int score;
	public Team teamA;
	public Team teamB;
	public bool possession;

	public GameState(Team teamA, Team teamB){
		this.teamA = teamA;
		this.teamB = teamB;
	}

}
