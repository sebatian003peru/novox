using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    private ScoreManagerSc SCM;
    public float moveForce = 1.5f; //Control Acceleration of the Ball
    public float NoSpeed, MaxSpeed;
    private Vector3 vi;
    public float Fspeed = 3f;
    private Vector3 startPos;
    private bool Active;
    public float delay;
    public float ElapsedTime;
    private float TimeOut;

	
    void Start()
    {
        NoSpeed = Fspeed;
        MaxSpeed = NoSpeed * 2.0f; //Control Speed of the Ball
        delay = 1f; // Time between swipes
        TimeOut=0;
		vi = new Vector3(0f, 0f, 0f);	
		Active = true;
        SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();

    }

    public void Update()
    {

         if(!Active){
			ElapsedTime=+ Time.deltaTime;
        }
		 if (ElapsedTime == delay){
        Active = true;
        ElapsedTime=TimeOut;
        }

        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.x < 0 ){
			     GetComponent<Rigidbody>().AddForce(Vector3.down * MaxSpeed);  //Move Down  
                 Active = false;    
				 Debug.Log("Swipe Left");
		}

		if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.x > 0) {
			 GetComponent<Rigidbody>().AddForce(Vector3.right * MaxSpeed);  //Move Right
                Active = false;
				Debug.Log("Swipe Right");
				}
        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.y <  0) {
            GetComponent<Rigidbody>().AddForce(Vector3.down * MaxSpeed);  //Move Down  
                 Active = false;    
				 Debug.Log("Swipe Down");
		}
        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.y > 0) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * MaxSpeed); //Move Up
                Active = false;
				Debug.Log("Swipe Up");
				}
		}

	   void FixedUpdate() //Ice Physics
    {
        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, MaxSpeed);
        GetComponent<Rigidbody>().AddForce(vi.normalized * moveForce, ForceMode.Impulse);

    }


}
