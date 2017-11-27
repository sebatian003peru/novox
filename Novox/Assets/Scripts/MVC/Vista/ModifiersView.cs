using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiersView : MonoBehaviour 
{
	public float _moveForce;
	public float _Fspeed;
	public float _NoSpeed;
	public float _MaxSpeed;
	public float _delay;
	public GameObject _Cube;
	Material _CubeRD;
	[SerializeField]
	ModifierController modifierController;
	void Start ()
	{
		_CubeRD= _Cube.GetComponent<Renderer>().material;
		modifierController = new ModifierController(_moveForce,_Fspeed,_NoSpeed,_MaxSpeed,_delay,_Cube,_CubeRD);
		
	}
	void Update()
	{
		
		modifierController.Test ();
	}
	
	
}
