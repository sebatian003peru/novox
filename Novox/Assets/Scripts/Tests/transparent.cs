using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparent : MonoBehaviour {

Color clour; 
 
     void Start(){
        
		 transform.GetComponent<Renderer>().material.color = new Color (1.0f,1.0f,1.0f,1.0f);
		
               
     }
 
}
