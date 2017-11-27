using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiersView : MonoBehaviour 
{
	public GameObject _Cube;
	Material _CubeRD;
	void Start ()
	{
		_CubeRD= _Cube.GetComponent<Renderer>().material;
	}
	void Update()
	{
		ModifierController modifierController = new ModifierController(_Cube,_CubeRD);
		modifierController.Test ();
	}
	
	
}
