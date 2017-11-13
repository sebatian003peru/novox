using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDead {

	private GameObject maestro;
	private ScoreManagerSc SCM;
	private float dead;

	void Start () 
	{
		maestro=GameObject.FindGameObjectWithTag ("CubeTag");
		SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
		//transform.SetParent(maestro.transform);
	}

	void Update () 
	{
		dead += 0.2f;

		if (dead >= 20f) 
		{
			//Destroy (this.gameObject);
		}
	}
	void OnTriggerEnter (Collider obj)
	{
		if (obj.gameObject.tag == "DetecterBonificationTag") 
		{
			SCM.ScoreCount += 10f;
			//Destroy (this.gameObject);
		}
	}
}
