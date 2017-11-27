using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerView : MonoBehaviour {

	private Rigidbody _rb;
	private ScoreManagerSc SCM;
	void Start () 
	{
		_rb = GetComponent <Rigidbody>();
		SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
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
			SCM.ScoreCount += 0.01f;
		}
	}

	void OnTriggerExit (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			_rb.useGravity = true;
			SceneManager.LoadScene ("GameOver");
		}
	}
}
