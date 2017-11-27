using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
[System.Serializable]
public class PlayerController : PlayerData {
    public float _moveForce_;
	public float _Fspeed_;
	public float _NoSpeed_;
	public float _MaxSpeed_;
	public float _delay_;
    public bool _InvertedControls_;
    public bool Active;
    public float TimeOut;
    public Vector3 vi = new Vector3(0f, 0f, 0f);
    public Rigidbody rb ;//= GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody> ();
    

    public PlayerController (bool InvertedControls_,float moveForce_,float NoSpeed_,float Fspeed_,float MaxSpeed_,float delay_ ,Rigidbody _Rb)
    {
        this._InvertedControls_ = InvertedControls_;
        this._moveForce_ = moveForce_;
        this._NoSpeed_ = NoSpeed_;
        this._Fspeed_ = Fspeed_;
        this._MaxSpeed_ = MaxSpeed_;
        this._delay_ = delay_;
        this.rb = _Rb;
    }

    public void Prueba ()
    {
        this.InvertedControls = _InvertedControls_;
        this.moveForce = _moveForce_;
        this.NoSpeed = _NoSpeed_;
        this.Fspeed = _Fspeed_;
        this.MaxSpeed = _MaxSpeed_;
        this.delay = _delay_;
    }
    public void Prueba2 ()
    {
        //this._moveForce_ = moveForce_;
        //this._NoSpeed_ = NoSpeed_;
        //this._Fspeed_ = Fspeed_;
        //this._MaxSpeed_ = MaxSpeed_;
        //this._delay_ = delay_;
        //this.rb = _Rb;
    }
    

    public void Inputs ()
    {
        
        if(Input.touchCount > 0)
        {
            int i = 0;
            for(i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                if (InvertedControls==false)

                {
                    if (touch.phase == TouchPhase.Ended)
                    {
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

                else if (InvertedControls == true)
                {
                        if (touch.phase == TouchPhase.Ended)
                    {
                        if (Input.GetTouch(0).deltaPosition.x < 0)
                        {
                            rb.AddForce(Vector3.right * MaxSpeed);
                            Active = false;    
                            Debug.Log("Swipe right inverted");
		                }
		                if (Input.GetTouch(0).deltaPosition.x > 0) 
                        {  
			                rb.AddForce(Vector3.left* MaxSpeed);
                            Active = false;
			                Debug.Log("Swipe left inverted");
		                }
                        if (Input.GetTouch(0).deltaPosition.y <  0) 
                        {
                            rb.AddForce(Vector3.up * MaxSpeed);
                            Active = false;    
		                	Debug.Log("Swipe up inverted");
		                }
                        if (Input.GetTouch(0).deltaPosition.y > 0) 
                        {
                            rb.AddForce (Vector3.down * MaxSpeed);
                            Active = false;
		                	Debug.Log("Swipe down inverted");
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
		}/* */
    }
    
    public void FixedUpdate()
	{
		rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
		rb.AddForce(vi.normalized * moveForce, ForceMode.Impulse);
    }


}
