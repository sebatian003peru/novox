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

    public PlayerData()
    {
        moveForce = 3f;
        Fspeed = 10f;
        NoSpeed = Fspeed;
        MaxSpeed = NoSpeed * 6.0f; //Control Speed of the Ball
        delay = 1f; // Time between swipes
    }

    public PlayerData(float moveForce, float Fspeed, float NoSpeed, float MaxSpeed, float Delay)
    {

        this.moveForce = moveForce;
        this.NoSpeed = NoSpeed;
        this.Fspeed = Fspeed;
        this.MaxSpeed = MaxSpeed;
        this.delay = Delay;
    }


}
