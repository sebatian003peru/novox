﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuctionController : SuctionData {


public SuctionController(int SuctionIndex,float PlayerHerfloat,float LimitPlayer,int ItsSuctionSelect, GameObject[] Suctions,GameObject SuctionsOn_Off){
this.SuctionIndex = SuctionIndex;
this.PlayerHerfloat = PlayerHerfloat;
this.LimitPlayer = LimitPlayer;
this.ItsSuctionSelect = ItsSuctionSelect;
this.Suctions = Suctions;
this.SuctionsOn_Off = SuctionsOn_Off;
}
}
