using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuctionView : MonoBehaviour
{
	public int _SuctionIndex;
	public float _PlayerHerfloat;
	public float _LimitPlayer;
	public int _ItsSuctionSelect;

	void Update () 
	{
		SuctionController suctionController = new SuctionController (_SuctionIndex,_PlayerHerfloat,_LimitPlayer,_ItsSuctionSelect);
	}


	void OnTriggerStay (Collider obj)
	{
		if (obj.gameObject.tag == "Player") 
		{
			_PlayerHerfloat +=0.2f;
			
		}
	}
	void OnTriggerExit (Collider obj)
	{
		if (obj.gameObject.tag == "Player") 
		{
			_PlayerHerfloat = -1;
		}
	}
}
