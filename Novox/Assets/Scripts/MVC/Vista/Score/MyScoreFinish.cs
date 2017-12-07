using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyScoreFinish : MonoBehaviour {

	DataScore _dataScore;

	public Text _Scoretxt;
	public Text _HighScoretxt;
	public float _ScoreCount;
	public float _HighScoreCount;

	// Use this for initialization
	void Start () 
	{
		_dataScore = GameObject.FindGameObjectWithTag ("DataScoreTag").GetComponent <DataScore>();
		_ScoreCount = _dataScore.Score_;
		_HighScoreCount = _dataScore.HightScore_;
		_Scoretxt.text = "Score : " + Mathf.Round(_ScoreCount);
		_HighScoretxt.text = " : " + Mathf.Round(_HighScoreCount);
	}
	public void TryAgain ()
	{
		SceneManager.LoadScene ("Build");
	}
}
