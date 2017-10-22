using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototipeSpawnBonus : MonoBehaviour {

	public Transform[] SpawnPoints;
	public GameObject AroBonus01;
	public GameObject AroBonus02;
	public GameObject AroBonus03;

	public int BonusIndex;

	void Start ()
	{
		BonusIndex = -1;
	}
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			BonusIndex = Random.Range (0, SpawnPoints.Length);
			Debug.Log ("BonusIndex " + BonusIndex);
			ItsSpawnCorrect ();
		}
	}
	void ItsSpawnCorrect ()
	{
		switch (BonusIndex) 
		{
		case 0:
			Instance01 ();
			break;
		case 1:
			Instance01 ();
			break;
		case 2:
			Instance02 ();
			break;
		case 3:
			Instance02 ();
			break;
		case 4:
			Instance03 ();
			break;
		case 5:
			Instance03 ();
			break;
		}
	}
	void Instance01 ()
	{
		Instantiate (AroBonus01,SpawnPoints [BonusIndex].position, SpawnPoints [BonusIndex].rotation);
	}
	void Instance02 ()
	{
		Instantiate (AroBonus02,SpawnPoints [BonusIndex].position, SpawnPoints [BonusIndex].rotation);
	}
	void Instance03 ()
	{
		Instantiate (AroBonus03,SpawnPoints [BonusIndex].position, SpawnPoints [BonusIndex].rotation);
	}
}