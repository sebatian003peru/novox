using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChild : MonoBehaviour {
	
	public Transform maestro;

	void Update () 
	{
		transform.SetParent(maestro);
	}
}
