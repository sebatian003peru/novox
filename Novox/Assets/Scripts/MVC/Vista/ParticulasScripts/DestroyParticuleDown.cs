using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticuleDown : DestroyParticuleUp {

	PlayerView Pw;

	void Start () 
	{
		thisParticuleSystem = GetComponent <ParticleSystem>();			
		Pw = GameObject.FindGameObjectWithTag ("Player").GetComponent <PlayerView> ();
	}

	void Update () 
	{
		if(thisParticuleSystem.isPlaying)
			return;
			else{
				Pw.SFXID = 5;
				Pw.AudioMan.Play();
				Destroy (gameObject);
			}
	}
}
