using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerType : MonoBehaviour {
	



	public GameObject C;
	public GameObject PF;
	public GameObject SF;
	public GameObject SG;
	public GameObject PG;
	// Use this for initialization
	public void onClick(){
		//string CenterText = C.GetComponent<Text> ();
		//string value =  C.GetComponent<>();

		string CText = C.GetComponent<Text> ().text;
		string PFText = PF.GetComponent<Text> ().text;
		string SFText = SF.GetComponent<Text> ().text;
		string SGText = SG.GetComponent<Text> ().text;
		string PGText = PG.GetComponent<Text> ().text;

		//Debug.Log (CText + ' ' + PFText + ' ' + SFText + ' ' + SGText + ' ' + PGText);

		PlayerGeneration.CenterGenerate (CText);
		PlayerGeneration.PowerForwardGenerate (PFText);
		PlayerGeneration.SmallForwardGenerate (SFText);
		PlayerGeneration.ShootingGuardGenerate (SGText);
		PlayerGeneration.PointGuardGenerate (PGText);
		//CenterType.Type = CText;
		//Debug.Log (CenterType.Type);
		SceneManager.LoadScene("HeyCoachAlpha");

	}
}
