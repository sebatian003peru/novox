using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuctionView : MonoBehaviour
{
	public int _SuctionIndex;
	public float _PlayerHerfloat;
	public float _LimitPlayer;
	public int _ItsSuctionSelect;
	public GameObject[] _Suctions;
	public GameObject _SuctionsOn_Off;
	
	void Start () 
	{
		_PlayerHerfloat = -1;
		_LimitPlayer = -1;
		_SuctionIndex = -1;
		_ItsSuctionSelect = 0;
	}
	void Update () 
	{
		SuctionController suctionController = new SuctionController (_SuctionIndex,_PlayerHerfloat,_LimitPlayer,_ItsSuctionSelect,_Suctions,_SuctionsOn_Off);
		proceso();
	}
	void proceso () 
	{
		if (_LimitPlayer >= 20f||_PlayerHerfloat==-1) 
		{
			_SuctionsOn_Off.SetActive (false);
			_PlayerHerfloat = -1;
			_LimitPlayer = -1;
			_SuctionIndex = -1;
			_ItsSuctionSelect = 0;
		}

		if (_PlayerHerfloat >= 45f) 
		{
			_ItsSuctionSelect++;
			if (_ItsSuctionSelect == 1) 
			{
				_SuctionIndex = Random.Range (0, _Suctions.Length);
			}
			_SuctionsOn_Off = _Suctions [_SuctionIndex];
			_SuctionsOn_Off.SetActive (true);
			_LimitPlayer += 0.2f;
		}	
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
