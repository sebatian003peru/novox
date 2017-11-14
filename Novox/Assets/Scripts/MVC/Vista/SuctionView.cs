using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuctionView : SuctionController 
{
	void OnTriggerStay (Collider obj)
	{
		if (obj.gameObject.tag == "Player") 
		{
			PlayerHerfloat +=0.2f;
			
		}
	}
	void OnTriggerExit (Collider obj)
	{
		if (obj.gameObject.tag == "Player") 
		{
			PlayerHerfloat = -1;
		}
	}
}
