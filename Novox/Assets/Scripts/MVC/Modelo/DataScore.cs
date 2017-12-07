using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScore : MonoBehaviour {

	public static DataScore groupSc;
	public ScoreManagerSc ScM;
	public float Score_;
	public float HightScore_;
	public bool ItsFinishScoreInGame;
	void Awake ()
	{
		if (groupSc == null) 
		{
			DontDestroyOnLoad (gameObject);
			groupSc = this;
		}
		else if(groupSc!=this)
		{
			Destroy (gameObject);
		}
		ItsFinishScoreInGame = false;
	}
	void Start () 
	{
		
	}
	void Update () 
	{
		ScM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc>();
		if(ItsFinishScoreInGame==true)
		{
			Score_ = ScM.ScoreCount;
			HightScore_ = ScM.HighScoreCount;
			DontDestroyOnLoad(this.gameObject);
		}
	}
	
}
