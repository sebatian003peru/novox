using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData  {
  
    public float Fspeed ;
    public float NoSpeed, MaxSpeed;
    public float moveForce;
    public float delay;
    public float ElapsedTime;

    public PlayerData()
    {
        moveForce = 3f;
        Fspeed = 10f;
        NoSpeed = Fspeed;
        MaxSpeed = NoSpeed * 6.0f; //Control Speed of the Ball
        delay = 1f; // Time between swipes
    }

    public PlayerData(float moveForce, float Fspeed, float NoSpeed, float MaxSpeed, float delay)
    {

        this.moveForce = moveForce;
        this.NoSpeed = NoSpeed;
        this.Fspeed = Fspeed;
        this.MaxSpeed = MaxSpeed;
        this.delay = delay;
    }


}
