using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoCalienteManager : MonoBehaviour 
{
	public GameObject[] Tiles;
	public Transform [] Spawns;
	public int Tile_Index;
	public int Spawn_Index;
	public bool Go_CoolDown;
	public float CoolDown;

	void Start ()
	{
		Go_CoolDown = true;
		CoolDown = 0;
		Tile_Index = 0;
		Spawn_Index = 0;
	}
	void Update ()
	{

		if(Go_CoolDown==true)
		{
			CoolDown += Time.deltaTime;
		}
		if(CoolDown >=7.5f)
		{
			Spawn_Index = Random.Range (0,Spawns.Length);
			Tile_Index = Random.Range (0,Tiles.Length);
			Instantiate (Tiles [Tile_Index],Spawns [Spawn_Index].position, Spawns [Spawn_Index].rotation);
			CoolDown = 0f;
			Go_CoolDown = false;
		}
	}
}
