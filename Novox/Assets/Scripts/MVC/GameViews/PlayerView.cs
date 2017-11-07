using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : NovoxElement {

	void Start()
	{
		//app.model.NoSpeed = app.model.Fspeed;
		//app.model.MaxSpeed = app.model.NoSpeed * 2.0f;
		//app.model.delay = 1f;
		//app.model.TimeOut = 0;
		//app.model.vi = new Vector3 (0f,0f,0f);
		//app.model.Active = true;
        //app.model.SCM = GameObject.FindGameObjectWithTag ("ScoreManagerTag").GetComponent <ScoreManagerSc> ();
	}
	void Update() 
	{
		app.controller.SwipeDetector(); 
		app.controller.IcePhysics(); 
	}
}
