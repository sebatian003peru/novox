using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonusController : SpawnBonusData {

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




