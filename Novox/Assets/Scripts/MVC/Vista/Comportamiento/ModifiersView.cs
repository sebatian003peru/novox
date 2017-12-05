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
	public bool _InvertedControls;
	public GameObject _Cube;
	Material _CubeRD;
	[SerializeField]
	public ModifierController modifierController;
	void Start ()
	{
		_CubeRD= _Cube.GetComponent<Renderer>().material;
		modifierController = new ModifierController(_InvertedControls,_moveForce,_Fspeed,_NoSpeed,_MaxSpeed,_delay,_Cube,_CubeRD);
		
	}
	void Update()
	{
		modifierController.Test ();
		_InvertedControls =modifierController._InvertedControls;
		_moveForce=modifierController._moveForce;
		_Fspeed=modifierController._Fspeed;
		_NoSpeed=modifierController._NoSpeed;
		_MaxSpeed=modifierController._MaxSpeed;
		_delay=modifierController._delay;
	}
	
	
}
