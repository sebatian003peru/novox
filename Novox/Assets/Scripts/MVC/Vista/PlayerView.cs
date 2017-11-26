using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour {

	private Rigidbody _rb;
	void Start () 
	{
		_rb = GetComponent <Rigidbody>();
	
	}
	
	
	void Update () 
	{
		PlayerController playerController = new PlayerController (_rb);
		playerController.Inputs();
		playerController.FixedUpdate();
	}
	void OnTriggerStay (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			_rb.useGravity = false;
			//SCM.ScoreCount += 0.01f;
		}
	}

	void OnTriggerExit (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			_rb.useGravity = true;
		}
	}
}
