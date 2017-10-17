using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {
 
    GameObject CubeTagS;      
    private Vector3 offset;         

  
    void Start () 
    {
		CubeTagS = GameObject.FindGameObjectWithTag("CubeTag");
        offset = new Vector3 (-16,-24,19);

    }
    

    void LateUpdate () 
    {
         transform.rotation = Quaternion.Euler(30,-45,0);
		transform.position = CubeTagS.transform.position - offset;
        
    }
}