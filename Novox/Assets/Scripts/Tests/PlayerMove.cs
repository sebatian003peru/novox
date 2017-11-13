using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove {

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
	
    void Start()
    {
        moveForce = 3f;
        Fspeed=10f;
        NoSpeed = Fspeed;
        MaxSpeed = NoSpeed * 6.0f; //Control Speed of the Ball
        delay = 1f; // Time between swipes
        TimeOut=0;
		vi = new Vector3(0f, 0f, 0f);	
		Active = true;
        SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody> ();

    }

    public void Update()
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
    }
    void FixedUpdate()
	{
		rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
		rb.AddForce(vi.normalized * moveForce, ForceMode.Impulse);
    }

	void OnTriggerStay (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			rb.useGravity = false;
			SCM.ScoreCount += 0.01f;
		}
	}

	void OnTriggerExit (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			rb.useGravity = true;
		}
	}
}
