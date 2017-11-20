using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonusController : SpawnBonusData {

    SpawnBonusController(int BonusIndex, float WaitTime, float SpawnTime)
    {
     this.BonusIndex = BonusIndex;
     this.WaitTime = WaitTime;
     this.SpawnTime = SpawnTime;
    }

    void Start ()
    {
        BonusIndex = -1;
        SelectInstance = false;
    }
    void Update ()
    {

        SpawnTime+= Time.deltaTime;

        
        if (SpawnTime == WaitTime) 
        {
            BonusIndex = Random.Range (0, SpawnPoints.Length);
            Debug.Log ("BonusIndex " + BonusIndex);
            SpawnTime=0;
            SelectInstance =true;
            TimeLimit();
        }
    }
    void TimeLimit() 
    {
      WaitTime = Random.Range(10,20);
    }
}




