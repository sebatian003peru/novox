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

	private Rigidbody rb;

	private ScoreManagerSc SCM;

    void Start()
    {
		rb = GetComponent<Rigidbody> ();
		SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
        NoSpeed = Fspeed;
        MaxSpeed = NoSpeed * 2.0f;
    }
    void Update()
    {
		vi = new Vector2(0f, 0f);
		if (Input.GetKey(KeyCode.W))
		{
			rb.AddForce (Vector3.up * MaxSpeed);
		}else if (Input.GetKey(KeyCode.S))
		{
			rb.AddForce(Vector3.down * MaxSpeed);
		}
		if (Input.GetKey(KeyCode.A))
		{
			rb.AddForce(Vector3.left * MaxSpeed);
		}
		if (Input.GetKey(KeyCode.D))
		{
			rb.AddForce(Vector3.right* MaxSpeed);
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rb.AddForce(Vector3.forward * MaxSpeed);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			rb.AddForce(Vector3.back* MaxSpeed);
		}
	}

	void FixedUpdate()
	{
		rb.velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, MaxSpeed);
		rb.AddForce(vi.normalized * moveForce, ForceMode.Impulse);
    }

	void OnTriggerStay (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			Debug.Log ("adentro");
			rb.useGravity = false;
			SCM.ScoreCount += 0.01f;
		}
	}

	void OnTriggerExit (Collider obj)
	{
		if(obj.gameObject.tag=="AreaScore")
		{
			Debug.Log ("fuera");
			rb.useGravity = true;
		}
	}
}








