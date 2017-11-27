using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerView : MonoBehaviour {
	public float _moveForce;
	public float _Fspeed;
	public float _NoSpeed;
	public float _MaxSpeed;
	public float _delay;
	private Rigidbody _rb;
	private ScoreManagerSc SCM;
	public ModifiersView MDV;
	PlayerController playerController;
	void Start () 
	{
		_rb = GetComponent <Rigidbody>();
		SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
		playerController = new PlayerController (_moveForce,_NoSpeed,_Fspeed,_MaxSpeed,_delay,_rb);
	}
	
	
	void Update () 
	{
		
		playerController.Inputs();
		playerController.FixedUpdate();
		this._moveForce = MDV._moveForce;
		this._NoSpeed = MDV._NoSpeed;
		this._Fspeed = MDV._Fspeed;
		this._MaxSpeed = MDV._MaxSpeed;
		this._delay = MDV._delay;
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
