using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticule : MonoBehaviour {

	private ParticleSystem thisParticuleSystem;

	void Start () 
	{
		thisParticuleSystem = GetComponent <ParticleSystem>();	
	}
	void Update () 
	{
		if(thisParticuleSystem.isPlaying)
			return;

		Destroy (gameObject);	
	}
}
