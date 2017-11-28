using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoCalienteManager : MonoBehaviour 
{
	public GameObject[] Tiles;
	public Transform [] Spawns;
	public int Tile_Index;
	public int Spawn_Index;
	public float Cooldown;

	void Start ()
	{
		Tile_Index = 0;
		Spawn_Index = 0;
	}
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Spawn_Index = Random.Range (0,Spawns.Length);
			Tile_Index = Random.Range (0,Tiles.Length);
			Instantiate (Tiles [Tile_Index],Spawns [Spawn_Index].position, Spawns [Spawn_Index].rotation);
		}
	}
}
