using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CovertirPadreSc : MonoBehaviour {

	private GameObject maestro;

	void Start () 
	{
		maestro=GameObject.FindGameObjectWithTag ("CubeTag");
		transform.SetParent(maestro.transform);	
	}
}
