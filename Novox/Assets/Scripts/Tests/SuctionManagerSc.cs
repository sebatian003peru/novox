using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuctionManagerSc {

	public GameObject[] Suctions;

	public GameObject suctionsOn_Off;

	private int SuctionIndex;

	private float PlayerHerfloat;

	private float LimitPlayer;

	private int ItsSuctionSelect;

	void Start () 
	{
		PlayerHerfloat = -1;
		LimitPlayer = -1;
		SuctionIndex = -1;
		ItsSuctionSelect = 0;
	}

	void Update () 
	{
		if (LimitPlayer >= 20f||PlayerHerfloat==-1) 
		{
			suctionsOn_Off.SetActive (false);
			PlayerHerfloat = -1;
			LimitPlayer = -1;
			SuctionIndex = -1;
			ItsSuctionSelect = 0;
		}

		if (PlayerHerfloat >= 45f) 
		{
			ItsSuctionSelect++;
			if (ItsSuctionSelect == 1) 
			{
				SuctionIndex = Random.Range (0, Suctions.Length);
			}
			suctionsOn_Off = Suctions [SuctionIndex];
			suctionsOn_Off.SetActive (true);
			LimitPlayer += 0.2f;
		}	
	}

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
