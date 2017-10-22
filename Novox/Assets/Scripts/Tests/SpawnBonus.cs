using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonus : DifficultyControl  {

BoxCollider Tube;
public float MinXaxis ;
public float MinYaxis ;
public float MinZaxis ;
public bool BonusSpawnActive;
int ID;
	void Start()
	{
		Tube = GetComponent<BoxCollider>();
		MinXaxis = -(Tube.size.x);
		MinYaxis = -(Tube.size.y);
		MinZaxis = -(Tube.size.z);
	}

	void ChooseTypeOfBonus()
	{
		ID = Random.Range(1,3);
	}

	private void ChooseSapwn()
	{
		switch (ID)
		{
			case 1: //Caso para cuando spawnea un anillo normal
			break;

			case 2: //Caso para cuando spawnea un punto caliente
			break;
		
		}
	}
	void Spawning()
	{
		Vector3 Position = new Vector3(Random.Range(Tube.size.x,MinXaxis), Random.Range(Tube.size.y, MinYaxis), Random.Range(Tube.size.z, MinZaxis));
	}
	void Update()
	{
		if (!BonusSpawnActive)
		{
			EplapsedTime -= Time.deltaTime;
		}
		if (EplapsedTime == 0)
		{
			BonusSpawnActive=true;
			ChooseTypeOfBonus();
			EplapsedTime = 0;
		}
		if (BonusSpawnActive)
		{
			Spawning();
			BonusLifeEnd -= Time.deltaTime;
		}
		if (BonusLifeEnd == 0)
		{ 
			BonusSpawnActive = false;
		}
	}
}
