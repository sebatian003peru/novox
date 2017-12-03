using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticuleGameOver : MonoBehaviour {

	private ParticleSystem thisParticuleSystem;
	private DataScore DS;

	void Start () 
	{
		DS = GameObject.FindGameObjectWithTag ("DataScoreTag").GetComponent <DataScore> ();
		thisParticuleSystem = GetComponent <ParticleSystem>();	
	}
	void Update () 
	{
		if(thisParticuleSystem.isPlaying)
			return;
			else{
				DS.ItsFinishScoreInGame = false;
				SceneManager.LoadScene ("GameOver");
				Destroy (gameObject);
			}

		
	}
}
