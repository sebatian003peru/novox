using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManagerSc : MonoBehaviour {

	public Text Scoretxt;
	public Text HighScoretxt;

	public float ScoreCount;
	public float HighScoreCount;
    
	



	void Start () 
	{
		if(PlayerPrefs.HasKey("HighScore"))
		{
			HighScoreCount =	PlayerPrefs.GetFloat ("HighScore");
		}
	}

	void Update () 
	{
		if (ScoreCount >= HighScoreCount) 
		{
			HighScoreCount = ScoreCount;
			PlayerPrefs.SetFloat ("HighScore",HighScoreCount);
		}

		Scoretxt.text = "Score: " + Mathf.Round(ScoreCount);
		HighScoretxt.text = "HighScore: " + Mathf.Round(HighScoreCount);
	}
}
