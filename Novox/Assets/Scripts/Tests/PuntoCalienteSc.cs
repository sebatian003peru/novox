using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoCalienteSc : MonoBehaviour {
	
	public float Velocidad;
	public Transform[] Puntos;
	int IndexActual = 0; 
	Vector3 PuntoA; 
	Vector3 PuntoB;
	float t; 
	float factorT;
	public Transform PlayerT;


	void Start()
	{
	    t = 1f;
	    CalcularValores();
	}

	void Update()
	{
	    t += factorT * Time.deltaTime;
	    if (t >= 1f)
	    {
	        IndexActual++;
	        if(IndexActual == Puntos.Length-1)
	        {
	            IndexActual = 0;
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
}
