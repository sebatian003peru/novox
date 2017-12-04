using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDead: MonoBehaviour {

	private Transform SpawnParticule;
	public GameObject UpParticule;
	public GameObject DownParticule;
	private GameObject maestro;
	private ScoreManagerSc SCM;
	private float dead;
	AroBonusManagerSc SB;
	

	void Start () 
	{
		SpawnParticule = GameObject.FindGameObjectWithTag ("AroManagerTag").GetComponent <Transform>();
		SB = GameObject.FindGameObjectWithTag ("AroManagerTag").GetComponent <AroBonusManagerSc> ();
		maestro=GameObject.FindGameObjectWithTag ("CubeTag");
		SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
		transform.SetParent(maestro.transform);
		
	}

	void Update () 
	{
		dead += Time.deltaTime;

		if (dead >= 7.8f) 
		{
			SB.Go_CoolDown = true;
			Instantiate(DownParticule,SpawnParticule.position,SpawnParticule.rotation);
			Destroy (this.gameObject);
		}
	}
	void OnTriggerEnter (Collider obj)
	{
		if (obj.gameObject.tag == "DetecterBonificationTag") 
		{
			SB.Go_CoolDown = true;
			SCM.ScoreCount += 10f;
			Instantiate(UpParticule,SpawnParticule.position,SpawnParticule.rotation);
			Destroy (this.gameObject);
		}
	}
}
