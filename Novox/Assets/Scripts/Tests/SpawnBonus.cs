using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonus : DifficultyControl  {

BoxCollider Tube;
BoxCollider BonusArea;

public float MinXaxis = 0;
public float MinYaxis = 0;
public float MinZaxis = 0;

float Xlimit;
float Ylimit;
float Zlimit;

public bool BonusSpawnActive;
int ID;

bool Bonus1Active;
bool Bonus2Active;


public SpawnBonus(float Xlimit, float Ylimit, float Zlimit){ //Estoy parametros definden el tamano del area del bonus
this.Xlimit = Xlimit;
this.Ylimit = Ylimit;
this.Zlimit = Zlimit;
}

void Start(){

	Bonus1Active = false;
	Bonus2Active = false;
	Tube = GetComponent<BoxCollider>();
	BonusArea.size = new Vector3 (Xlimit,Ylimit,Zlimit);
    
}

void ChooseTypeOfBonus() {

ID = Random.Range(1,3);

}

private void ChooseSapwn(){
	switch (ID){

		case 1: //Caso para cuando spawnea un anillo normal
		
		Xlimit = 1f;

		Ylimit = 1f;

		Zlimit = 1f;

		Bonus1Active = true;

		break;

		case 2: //Caso para cuando spawnea un punto caliente

		Xlimit = 4f;

		Ylimit = 4f;

		Zlimit = 4f;
		
		Bonus2Active = true;

		break;
		
		}


	}




void OnTriggerEnter (Collider col){
	
	if (Bonus1Active) {
	if (col.gameObject.tag == "Player"){
		// Multiplicar puntaje por 2
	}
}

}

void OnTriggerStay(Collider col) {

	if (Bonus2Active){
	if (col.gameObject.tag== "Player"){
		//Multiplicar puntaje por 4
	}
	}
}

void Spawning(){

Vector3 Position = new Vector3(Random.Range(Tube.size.x,MinXaxis), Random.Range(Tube.size.y, MinYaxis), Random.Range(Tube.size.z, MinZaxis));

Instantiate(BonusArea, Position, Quaternion.identity);

}

void DestroyBonus(){

	Destroy(BonusArea);
}


void Update(){

	if (!BonusSpawnActive){
 EplapsedTime -= Time.deltaTime;
 }

 if (EplapsedTime == 0){
	 BonusSpawnActive=true;
	  ChooseTypeOfBonus();
	  EplapsedTime = 0;
 }
 if (BonusSpawnActive){
  Spawning();
  BonusLifeEnd -= Time.deltaTime;

if (BonusLifeEnd == 0){ //Cuando el tiempo de vida del bonus se termine que lo destruya y comience la espera para spawnear otro
	BonusSpawnActive = false;
	Bonus1Active=false;
	Bonus2Active = false;
	DestroyBonus();
}




}



}
}
