using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ModifierController : ModifiersData {
    public float _moveForce;
	public float _Fspeed;
	public float _NoSpeed;
	public float _MaxSpeed;
	public float _delay;
	[SerializeField]
    private float Cooldown = 5f;
    [SerializeField]
    private float Duration = 5f;
    public void Test()
    {
        Debug.Log ("holavoid");
        if (ActivatedCooldown)
        { // Cooldown es el periodo que representa el intermedio entre dos cambios. Es decir que cuando este acabe ocurrira un cambio
            Cooldown-= Time.deltaTime;
            Debug.Log ("hola");
            }else if (!ActivatedCooldown)
            {
                Cooldown =  x;
            }

        if (Cooldown <= 0)
        {  // Al acabar el cooldown se llama al metodo para elegir un id aleatorio y se inicia el contador que determina la duracion del cambio
            chooseEffectid();
            x-= 0.5f;
            ActivatedCooldown = false;
            ActivatedEffect = true;
            Debug.Log ("hola4");
        }

        if (ActivatedEffect)
        {
            Duration-= Time.deltaTime;
            ChooseEffect ();
            Debug.Log ("hola5");
            }else if (!ActivatedEffect)
            { 
                Duration = y;
            }

        if (Duration<=0)
        {
            y+=0.5f;
            ActivatedCooldown = true;
            ActivatedEffect=false;
            Debug.Log("Normal");
        }
        
    }
    public void chooseEffectid()
    { // Metodo para lanzar un id aleatorio entre los 4 casos
        Selected = Random.Range(1,5);
        Debug.Log ("hola2");
    }
    public void ChooseEffect(){ // casos o cambios de estado del jugador
    Debug.Log ("hola3");
    switch(Selected){

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

    public void RedEffect()
    {
        _Fspeed=2;
        _NoSpeed=2;
        _MaxSpeed=2;
        _moveForce =2;
        _delay=1;
        CubeRD.color = Color.red;
        Debug.Log("Red Effect triggered");
     }

    public void GreenEffect()
    {
        _Fspeed=6;
        _NoSpeed=6;
        _MaxSpeed=6;
        _moveForce =6;
        _delay=1;
        CubeRD.color = Color.green;
        Debug.Log("Green Effect triggered");
    }

    public void YellowEffect()
    {
        _Fspeed= 4;
        _NoSpeed= 4;
        _MaxSpeed= 4;
        _moveForce = 4;
        _delay=2;
        CubeRD.color = Color.yellow;
        Debug.Log("Yellow Effect triggered");
    }

    public void BlueEffect()
    {
        CubeRD.color = Color.blue;
        Debug.Log("Blue Effect triggered");

    }
    public void DefaultMovement()
    { // Variables default del movimiento del jugador
        _Fspeed=4;
        _NoSpeed=4;
        _MaxSpeed=4;
        _moveForce =4;
        _delay=1;
        CubeRD.color = Color.white;     
    }


    public ModifierController(float moveForce_,float NoSpeed_,float Fspeed_,float MaxSpeed_,float delay_ ,GameObject _Cube_,Material _CubeRD_)
    {
        this._moveForce = moveForce_;
        this._NoSpeed = NoSpeed_;
        this._Fspeed = Fspeed_;
        this._MaxSpeed = MaxSpeed_;
        this._delay = delay_;
        this.Cube = _Cube_;
        this.CubeRD = _CubeRD_;
    }
    
}
