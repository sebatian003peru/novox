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
    public bool _InvertedControls;
	[SerializeField]
    private float Cooldown = 5f;
    [SerializeField]
    private float Duration = 5f;
    PlayerView pw;
    public AudioClip ModifierSFX;

    public void Test()
    {
        DefaultMovement();

        if (ActivatedCooldown)
        { // Cooldown es el periodo que representa el intermedio entre dos cambios. Es decir que cuando este acabe ocurrira un cambio
            Cooldown-= Time.deltaTime;
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
        }

        if (ActivatedEffect)
        {
            Duration-= Time.deltaTime;
            ChooseEffect ();
            }else if (!ActivatedEffect)
            { 
                Duration = y;
            }

        if (Duration<=0)
        {
            DefaultMovement();
            y+=0.5f;
            ActivatedCooldown = true;
            ActivatedEffect=false;
        }

        if (x<=1){
            x=1;
        }
        if (y>=10){
            y=10;
        }
        
    }
    public void chooseEffectid()
    { // Metodo para lanzar un id aleatorio entre los 4 casos
        Selected = Random.Range(1,5);
    }
    public void ChooseEffect(){ // casos o cambios de estado del jugador
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
        _InvertedControls = false;
        _Fspeed=70;
        _NoSpeed=70;
        _MaxSpeed=70;
        _moveForce =70;
        _delay=70;
        CubeRD.color = Color.red;
        Debug.Log("Red Effect triggered");
     }

    public void GreenEffect()
    {
        _InvertedControls = false;
        _Fspeed= 170;
        _NoSpeed= 170;
        _MaxSpeed= 170;
        _moveForce = 170;
        _delay=0f;
        CubeRD.color = Color.green;
        Debug.Log("Green Effect triggered");
    }

    public void YellowEffect()
    {
        _InvertedControls = false;
        _Fspeed= 100;
        _NoSpeed= 100;
        _MaxSpeed= 100;
        _moveForce = 100;
        _delay=0.5f;
        CubeRD.color = Color.yellow;
        Debug.Log("Yellow Effect triggered");
    }

    public void BlueEffect()
    {
        _InvertedControls = true;
        _Fspeed=100;
        _NoSpeed=100;
        _MaxSpeed=100;
        _moveForce =100;
        _delay=0;
        CubeRD.color = Color.blue;
        Debug.Log("Blue Effect triggered");

    }
    public void DefaultMovement()
    { // Variables default del movimiento del jugador
        _InvertedControls = false;
        _Fspeed=100;
        _NoSpeed=100;
        _MaxSpeed=100;
        _moveForce =100;
        _delay=0f;
        CubeRD.color = Color.white;     
    }


    public ModifierController(bool InvertedControls_,float moveForce_,float NoSpeed_,float Fspeed_,float MaxSpeed_,float delay_ ,GameObject _Cube_,Material _CubeRD_)
    {
        this._InvertedControls = InvertedControls_;
        this._moveForce = moveForce_;
        this._NoSpeed = NoSpeed_;
        this._Fspeed = Fspeed_;
        this._MaxSpeed = MaxSpeed_;
        this._delay = delay_;
        this.Cube = _Cube_;
        this.CubeRD = _CubeRD_;
    }
    
}
