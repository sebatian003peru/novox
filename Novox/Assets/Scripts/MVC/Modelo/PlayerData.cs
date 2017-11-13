using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData  {
  private ScoreManagerSc SCM;
    public float Fspeed ;
    public float NoSpeed, MaxSpeed;
    public float moveForce;
    public float delay;
    private Vector3 vi;
    private Vector3 startPos;
    private bool Active;
    public float ElapsedTime;
    private float TimeOut;
    private Rigidbody rb;


}
