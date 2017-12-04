using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoCalienteSc : MonoBehaviour {
	
	private Transform SpawnParticule;
	public GameObject UpParticule;
	public GameObject DownParticule;
	public GameObject ThisDestroy;
	public float Velocidad;
	public Transform[] Puntos;
	int IndexActual = 0; 
	Vector3 PuntoA; 
	Vector3 PuntoB;
	float t; 
	float factorT;
	public Transform PlayerT;
	ScoreManagerSc SCM;
	PuntoCalienteManager PCM;
	PlayerView VW;
	public float Dead;

	void Start()
	{
		SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
		PCM = GameObject.FindGameObjectWithTag ("PuntoCalienteManagerTag").GetComponent <PuntoCalienteManager> ();
		SpawnParticule = GameObject.FindGameObjectWithTag ("PuntoCalienteManagerTag").GetComponent <Transform>();
	    t = 1f;
	    CalcularValores();
	}

	void Update()
	{
		if(Dead >= 3f)
		{
			PCM.Go_CoolDown = true;
			SCM.ScoreCount +=6;
			Instantiate(UpParticule,SpawnParticule.position,SpawnParticule.rotation);
			Destroy(ThisDestroy);
		}
	    t += factorT * Time.deltaTime;
	    if (t >= 1f)
	    {
	        IndexActual++;
	        if(IndexActual == Puntos.Length-1)
	        {
				PCM.Go_CoolDown = true;
				Instantiate(DownParticule,SpawnParticule.position,SpawnParticule.rotation);
	            Destroy(ThisDestroy);
	        }
	        CalcularValores();
	    }

	    transform.position = Vector3.Lerp(PuntoA, PuntoB, t);
		PlayerT.rotation = Puntos [IndexActual].rotation;
	}

	void CalcularValores()
	{
	    PuntoA = Puntos[IndexActual].position;
	    PuntoB = Puntos[IndexActual + 1].position;
	    t = 1.0f - t;
	    factorT = 1.0f / Vector3.Distance(PuntoA, PuntoB) * Velocidad;
	}
	void OnTriggerStay(Collider obj)
	{
		if(obj.gameObject.tag =="Player")
		{
			Dead += Time.deltaTime;
		}
	}
	void OnTriggerExit (Collider obj)
	{
		if(obj.gameObject.tag =="Player")
		{
			Dead = 0;
		}
	}
}
