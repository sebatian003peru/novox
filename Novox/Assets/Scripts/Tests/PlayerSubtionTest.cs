using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSubtionTest : MonoBehaviour {

	public Transform Player;
	public float RotSpeed=3f,MoveSpeed=3f;
	public bool Follow;

	void Start()
	{
		Follow = false;
		Player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	void Update ()
	{
		if (Follow == true) 
		{
			transform.rotation = Quaternion.Slerp (transform.rotation,Quaternion.LookRotation(Player.position - transform.position),RotSpeed*Time.deltaTime);

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;
		}
	}
	void OnTriggerStay (Collider obj)
	{
		if (obj.gameObject.tag == "Player") 
		{
			Follow = true;
		}
	}
	void OnTriggerExit (Collider obj)
	{
		if (obj.gameObject.tag == "Player") 
		{
			Follow = false;
		}
	}
}
