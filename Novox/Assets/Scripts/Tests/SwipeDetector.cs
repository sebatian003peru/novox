using UnityEngine;
using System.Collections;

public class SwipeDetector : MonoBehaviour 
{
	
	public float minSwipeDistY;

	public float minSwipeDistX;

    public float minSwipeDistZ;

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

    }

    


    void ChooseEffect(Modifiers Mod){
        
    }

    void Update()
	{
        vi = new Vector3(0f, 0f, 0f);	

		{
            if (Active){
			Touch touch = Input.touches[0];//Reset Finger Position
            switch (touch.phase) //Start Tracking Finger Position
            {
			case TouchPhase.Began:

				 startPos = touch.position;
				
			break;

			case TouchPhase.Ended: //After Calibrating, Calculate direction and length of the Swipe

                float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;

				if (swipeDistVertical > minSwipeDistY) 
						
					{
						
						float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

                        if (swipeValue > 0)
                        {
                            GetComponent<Rigidbody>().AddForce(Vector3.up * MaxSpeed); //Move Up
                            Active = false;

                        }

                        else if (swipeValue < 0) {

                            GetComponent<Rigidbody>().AddForce(Vector3.down * MaxSpeed);  //Move Down  
                            Active = false;          
                        }

                    }
					
				float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
					
				if (swipeDistHorizontal > minSwipeDistX) 
						
					{
						
						float swipeValue = Mathf.Sign(touch.position.x - startPos.x);

                        if (swipeValue > 0) {
                            GetComponent<Rigidbody>().AddForce(Vector3.right * MaxSpeed);  //Move Right
                            Active = false;
                        }


                        else if (swipeValue < 0)
                        {
                            GetComponent<Rigidbody>().AddForce(Vector3.left * MaxSpeed); //Move Left
                            Active = false;
                        }

                    }
            break;
            }
		}

        else if(!Active){
            ElapsedTime=+ Time.deltaTime;
        }
	}

    if (ElapsedTime == delay){
        Active = true;
        ElapsedTime=TimeOut;
    }
    }

    void FixedUpdate() //Ice Physics
    {
        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, MaxSpeed);
        GetComponent<Rigidbody>().AddForce(vi.normalized * moveForce, ForceMode.Impulse);

    }

}