using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : CubeData {
  public CubeController(float _Speed, int _numberRandom, float _termina, int _timeStop,bool _rote)
  {
   this.Speed = _Speed;
   this.numberRandom = _numberRandom;
   this.termina = _termina;
   this.timeStop = _timeStop;
   this.rote = _rote;
  }

  public void RandomRotation (int _numberRandom,int _timeStop,float _termina,bool _rote)
    {
        /* 
        if(_numberRandom==-1)
        {
            _timeStop++;
            Debug.Log("correWey:,v");
        }

        if(_termina >=110f)
        {
            _rote=false;
            _numberRandom=-1;
            _termina=0;
            Debug.Log("terminaPues:,v");
        }

        if(_timeStop==30f)
        {
            _numberRandom = Random.Range(0,5);
            Debug.Log(_numberRandom);
            _timeStop = 0; 
        }
        */
    }
}
