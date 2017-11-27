using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : PlayerData {
    public float _moveForce;
	public float _Fspeed;
	public float _NoSpeed;
	public float _MaxSpeed;
	public float _delay;
    private bool Active;
    private float TimeOut;
    private Vector3 vi = new Vector3(0f, 0f, 0f);
    private Rigidbody rb ;//= GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody> ();
    

    public PlayerController (float moveForce_,float NoSpeed_,float Fspeed_,float MaxSpeed_,float delay_ ,Rigidbody _Rb)
    {
        this.moveForce = moveForce_;
        this.NoSpeed = NoSpeed_;
        this.Fspeed = Fspeed_;
        this.MaxSpeed = MaxSpeed_;
        this.delay = delay_;
        this.rb = _Rb;
    }
    

    public void Inputs ()
    {

          if(Input.touchCount > 0)
         {
             int i = 0;
             for(i = 0; i < Input.touchCount; i++)
             {
                 Touch touch = Input.GetTouch(i);

         if ( touch.phase == TouchPhase.Began ) {
          
        if (touch.phase == TouchPhase.Ended){

        if (Input.GetTouch(0).deltaPosition.x < 0)
        {
            rb.AddForce(Vector3.left * MaxSpeed);
            Active = false;    
			Debug.Log("Swipe Left");
		}
		if (Input.GetTouch(0).deltaPosition.x > 0) 
        {
			rb.AddForce(Vector3.right* MaxSpeed);
            Active = false;
			Debug.Log("Swipe Right");
		}
        if (Input.GetTouch(0).deltaPosition.y <  0) 
        {
            rb.AddForce(Vector3.down * MaxSpeed);
            Active = false;    
			Debug.Log("Swipe Down");
		}
        if (Input.GetTouch(0).deltaPosition.y > 0) 
        {
            rb.AddForce (Vector3.up * MaxSpeed);
            Active = false;
			Debug.Log("Swipe Up");
		}
        
        }
      
         }
          }
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
         
    
    public void FixedUpdate()
	{
		rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
		rb.AddForce(vi.normalized * moveForce, ForceMode.Impulse);
    }


}
