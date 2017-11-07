using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovoxModel : NovoxElement {

//Game Data
    
	// Player Data
	public ScoreManagerSc SCM;
    public float Fspeed = 3f;
    public float NoSpeed, MaxSpeed;
    public float moveForce = 1.5f; //Control Acceleration of the Ball
    public float delay;
    public Vector3 vi;
    public Vector3 startPos;
    public bool Active;
    public float ElapsedTime;
    public float TimeOut;

	//ModifiersData

	public GameObject Cube;
    public Material CubeRD;
    public int Selected;
    public float DifficultTimer;
    public float x = 5; //Controlls Cooldown of Effect
    public float y = 5; //Controls Duration of Effect
    public bool ActivatedCooldown;
    public bool ActivatedEffect; 

	//Suction

	public GameObject attractedTo;
    public bool inside;
    public Rigidbody PlayerRb;
    public float strengthOfAttraction;

	//General

	public Collider col;

}
