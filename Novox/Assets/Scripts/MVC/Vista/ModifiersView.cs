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
	void Start ()
	{
		ModifierController modifierController = new ModifierController(_moveForce,_Fspeed,_NoSpeed,_MaxSpeed,_delay);
	}
	
	
}
