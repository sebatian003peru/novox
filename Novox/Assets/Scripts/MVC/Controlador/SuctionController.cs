using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuctionController : SuctionData {


public SuctionController(int SuctionIndex,float PlayerHerfloat,float LimitPlayer,int ItsSuctionSelect){
this.SuctionIndex = SuctionIndex;
this.PlayerHerfloat = PlayerHerfloat;
this.LimitPlayer = LimitPlayer;
this.ItsSuctionSelect = ItsSuctionSelect;
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
}
