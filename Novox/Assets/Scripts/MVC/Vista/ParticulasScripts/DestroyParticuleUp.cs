using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticuleUp : MonoBehaviour {

	public ParticleSystem thisParticuleSystem;

	void Start () 
	{
		thisParticuleSystem = GetComponent <ParticleSystem>();	
	}
	void Update () 
	{
		DetectLifePartucle();
	}
	public void DetectLifePartucle()
	{
		if(thisParticuleSystem.isPlaying)
			return;

		Destroy (gameObject);	
	}
}
