using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScore : MonoBehaviour {

	public static DataScore groupSc;
	ScoreManagerSc ScM;
	public float Score_;
	public float HightScore_;
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

	}
	void Start () 
	{
		

	}
	
	// Update is called once per frame
	void Update () 
	{
		ScM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc>();
		Score_ = ScM.ScoreCount;
		HightScore_ = ScM.HighScoreCount;
		DontDestroyOnLoad(this.gameObject);
	}
	
}
