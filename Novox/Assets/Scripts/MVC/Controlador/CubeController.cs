using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : CubeData {

  public void RandomRotation ()
    {
        if(numberRandom==-1)
        {
            timeStop++;
        }

        if(termina >=110f)
        {
            rote=false;
            numberRandom=-1;
            termina=0;
        }

        if(timeStop==30f)
        {
            numberRandom = Random.Range(0,5);
            Debug.Log(numberRandom);
            timeStop = 0; 
        }
        
    }
}
