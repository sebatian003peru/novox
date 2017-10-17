using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{

    public float boostpower;
    public float moveForce = 1.05f;
    public float NoSpeed, MaxSpeed;
    private Vector3 vi;
	
	static private float Fspeed=3f;

    void Start()
    {
        NoSpeed = Fspeed;
        MaxSpeed = NoSpeed * 2.0f;

    }

    void Update()
    {

      

        vi = new Vector2(0f, 0f);

      


            if (Input.GetKey(KeyCode.W))
            {
                
                GetComponent<Rigidbody>().AddForce(Vector3.up * MaxSpeed);

            }
            else if (Input.GetKey(KeyCode.S))
            {
               GetComponent<Rigidbody>().AddForce(Vector3.down * MaxSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {

                GetComponent<Rigidbody>().AddForce(Vector3.left * MaxSpeed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.right* MaxSpeed);
            }

              if (Input.GetKey(KeyCode.UpArrow))
            {

                GetComponent<Rigidbody>().AddForce(Vector3.forward * MaxSpeed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.back* MaxSpeed);
            }

        }

		
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, MaxSpeed);
        GetComponent<Rigidbody>().AddForce(vi.normalized * moveForce, ForceMode.Impulse);

    }
    }








