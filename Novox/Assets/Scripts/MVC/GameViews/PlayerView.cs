using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : NovoxElement {
	void Update() 
	{
		app.controller.SwipeDetector();
		app.controller.IcePhysics();
	}
}
