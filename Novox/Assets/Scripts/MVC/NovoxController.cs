using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NovoxController : NovoxElement {

//Control of the Player
	
	public void SwipeDetector()
    {
        if(!app.model.Active)
        {
			app.model.ElapsedTime=+ Time.deltaTime;
        }
        if (app.model.ElapsedTime == app.model.delay)
        {
            app.model.Active = true;
            app.model.ElapsedTime=app.model.TimeOut;
        }
        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.x < 0 )
        {
            GetComponent<Rigidbody>().AddForce(Vector3.down * app.model.MaxSpeed);  //Move Down  
            app.model.Active = false;    
			Debug.Log("Swipe Left");
		}
		if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.x > 0) 
        {
			GetComponent<Rigidbody>().AddForce(Vector3.right * app.model.MaxSpeed);  //Move Right
            app.model.Active = false;
			Debug.Log("Swipe Right");
		}
        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.y <  0) 
        {
            GetComponent<Rigidbody>().AddForce(Vector3.down * app.model.MaxSpeed);  //Move Down  
            app.model.Active = false;    
			Debug.Log("Swipe Down");
		}
        if (Input.touchCount > 0  && Input.GetTouch(0).deltaPosition.y > 0) 
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * app.model.MaxSpeed); //Move Up
            app.model.Active = false;
			Debug.Log("Swipe Up");
		}
    }

	   public void IcePhysics() //Ice Physics
    {
        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody>().velocity, app.model.MaxSpeed);
        GetComponent<Rigidbody>().AddForce(app.model.vi.normalized * app.model.moveForce, ForceMode.Impulse);
    }

	public void PlayerMove(float fspeed, float noSpeed, float maxSpeed, float MoveF, float delayed) 
    { // Constructor para poder modificar las variables en los casos del switch
    fspeed = app.model.Fspeed;
    noSpeed = app.model.NoSpeed;
    maxSpeed= app.model.MaxSpeed;
    MoveF= app.model.moveForce;
    delayed = app.model.delay;
    }

// Modifiers Components

	void DefaultMovement()
    { // Variables default del movimiento del jugador
    app.model.Fspeed=4;
    app.model.NoSpeed=4;
    app.model.MaxSpeed=4;
    app.model.moveForce =4;
    app.model.delay=1;
    app.model.CubeRD.color = Color.white;     
    }

	void RedEffect()
    {
    app.model.Fspeed=2;
    app.model.NoSpeed=2;
    app.model.MaxSpeed=2;
    app.model.moveForce =2;
    app.model.delay=1;
    app.model.CubeRD.color = Color.red;
    Debug.Log("Red Effect triggered");
    }

    void GreenEffect()
    {
    app.model.Fspeed=6;
    app.model.NoSpeed=6;
    app.model.MaxSpeed=6;
    app.model.moveForce =6;
    app.model.delay=1;
    app.model.CubeRD.color = Color.green;
    Debug.Log("Green Effect triggered");
    }

    void YellowEffect()
    {
    app.model.Fspeed= 4;
    app.model.NoSpeed= 4;
    app.model.MaxSpeed= 4;
    app.model.moveForce = 4;
    app.model.delay=2;
    app.model.CubeRD.color = Color.yellow;
    Debug.Log("Yellow Effect triggered");
    }

    void BlueEffect()
    {
    app.model.CubeRD.color = Color.blue;
    Debug.Log("Blue Effect triggered");
    }

	void chooseEffectid()
    { // Metodo para lanzar un id aleatorio entre los 4 casos
    app.model.Selected = Random.Range(1,5);
    }

	public void ChooseEffect(){ // casos o cambios de estado del jugador

    switch(app.model.Selected){

        case 1: //Rojo: La pelota es mas pesada
        RedEffect();
        break;

        case 2://Verde: La pelota el mas ligera
        GreenEffect();
        break;

        case 3: //Amarillo: el delay entre swipes aumenta
        YellowEffect();
        break;

        case 4: //Azul: Los controles se invierten (LAS VARIABLES PAFRA ELLO FALTAS)
        BlueEffect();
        break;

        }
    }

//Modifiers and Internal Voids

	public void ModifiersAct()
	{
		float Cooldown=5f;
        float Duration=5f;

		if (app.model.ActivatedCooldown)
        { // Cooldown es el periodo que representa el intermedio entre dos cambios. Es decir que cuando este acabe ocurrira un cambio
        Cooldown-= Time.deltaTime;
        }
		else if (!app.model.ActivatedCooldown)
        {
            Cooldown =  app.model.x;
        }
        if (Cooldown <= 0)
        {  // Al acabar el cooldown se llama al metodo para elegir un id aleatorio y se inicia el contador que determina la duracion del cambio
        chooseEffectid();
        app.model.x-= 0.5f;
        app.model.ActivatedCooldown = false;
        app.model.ActivatedEffect = true;
        }

		if (app.model.x<=0)
		{
			app.model.x=1f;

		}

        if (app.model.ActivatedEffect)
        {
        Duration-= Time.deltaTime;
        ChooseEffect();
        }else if (!app.model.ActivatedEffect)
        { 
            Duration = app.model.y;
        }

        if (Duration<=0)
        {
        DefaultMovement();
        app.model.y+=0.5f;
        app.model.ActivatedCooldown = true;
        app.model.ActivatedEffect=false;
        Debug.Log("Normal");
        }
	}

// Suction Void

    public void DetectSuctionElements()
	{
		app.model.attractedTo = GameObject.FindGameObjectWithTag("Player");
        app.model.PlayerRb= app.model.attractedTo.GetComponent<Rigidbody>();

	}

    public void Suction()
	{
		if (app.model.inside == true) 
         {
         Vector3 direction = transform.position - app.model.attractedTo.transform.position;
         app.model.PlayerRb.AddForce (app.model.strengthOfAttraction * direction);
         }
    }
     
    public void DetectInside ()
    {      
     if (app.model.col.gameObject.tag =="Player")
	  {  
      app.model.inside =true;
      }    
    }

    public void DetectExitInside (){
	{
    if (app.model.col.gameObject.tag =="Player") 
            {          
			app.model.inside =false;
             }
         }

	}
}

