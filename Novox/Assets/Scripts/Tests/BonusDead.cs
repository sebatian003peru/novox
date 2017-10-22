using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDead : MonoBehaviour {

	private ScoreManagerSc SCM;
	public float dead;

	void Start () 
	{
		SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
	}

	void Update () 
	{
		dead += 0.2f;

		if (dead >= 20f) 
		{
			Destroy (this.gameObject);
		}
	}
	void OnTriggerEnter (Collider obj)
	{
		if (obj.gameObject.tag == "DetecterBonificationTag") 
		{
			SCM.ScoreCount += 10f;
			Destroy (this.gameObject);
		}
	}
}
