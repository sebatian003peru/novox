using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame2 : MonoBehaviour {

	void OnTriggerEnter (Collider obj)
	{
		if(obj.gameObject.tag =="Player")
		{
			SceneManager.LoadScene ("GameOver2");
		}
	}
}
