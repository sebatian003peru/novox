using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : PlayerData {

    private bool Active;
    private float TimeOut;
    private Vector3 vi = new Vector3(0f, 0f, 0f);
    private Rigidbody rb ;//= GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody> ();
    //private ScoreManagerSc SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();

    public PlayerController (Rigidbody _Rb)
    {
        this.rb = _Rb;
    }
       public void PlayerData(float moveForce, float Fspeed, float NoSpeed, float MaxSpeed, float Delay)
    {
        Fspeed=10f;
        moveForce=3f;
        NoSpeed=18f;
        MaxSpeed=60f;
        delay=1f;
    }
    

    public void Inputs ()
    {
        
        if (Input.GetTouch(0).phase == TouchPhase.Ended){
        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.x < 0)
        {
            rb.AddForce(Vector3.left * MaxSpeed);
            Active = false;    
			Debug.Log("Swipe Left");
		}
		if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.x > 0) 
        {
			rb.AddForce(Vector3.right* MaxSpeed);
            Active = false;
			Debug.Log("Swipe Right");
		}
        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.y <  0) 
        {
            rb.AddForce(Vector3.down * MaxSpeed);
            Active = false;    
			Debug.Log("Swipe Down");
		}
        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.y > 0) 
        {
            rb.AddForce (Vector3.up * MaxSpeed);
            Active = false;
			Debug.Log("Swipe Up");
		}
        }
         
        /* //TestControllers
        if (Input.GetKey (KeyCode.A))
        {
            rb.AddForce(Vector3.left * MaxSpeed);
            Active = false;    
			Debug.Log("Swipe Left");
		}
		if (Input.GetKey (KeyCode.D))
        {
			rb.AddForce(Vector3.right* MaxSpeed);
            Active = false;
			Debug.Log("Swipe Right");
		}
        if (Input.GetKey (KeyCode.S))
        {
            rb.AddForce(Vector3.down * MaxSpeed);
            Active = false;    
			Debug.Log("Swipe Down");
		}
        if (Input.GetKey (KeyCode.W))
        {
            rb.AddForce (Vector3.up * MaxSpeed);
            Active = false;
			Debug.Log("Swipe Up");
		} */
         
    }
    public void FixedUpdate()
	{
		rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
		rb.AddForce(vi.normalized * moveForce, ForceMode.Impulse);
    }


}
