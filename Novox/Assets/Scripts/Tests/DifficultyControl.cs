using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyControl : SwipeDetector {

	public float ElapsedTimer;
	public float Cooldown = 30; /// For Modifiers
    public float Duration = 15; /// For Modifiers

	public int ID;

    public float EplapsedTime = 15; // For Spawning Bonus
    public float BonusLifeEnd = 20; // For Spawning Bonus


	
	 
	 void Update(){

		 ElapsedTimer += Time.deltaTime;

		 if (ElapsedTimer==30){

			 Cooldown-= 0.5f;
			 Duration+= 0.5f;
			 ElapsedTime +=0.5f;
			 BonusLifeEnd -=0.5f;
			 ResetTimer();

			 

		 }
		 }



	 void ResetTimer() {

		 ElapsedTimer = 0f;
		 }

}


