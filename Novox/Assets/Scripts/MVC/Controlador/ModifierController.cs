using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifierController : ModifiersData {
    public float _moveForce;
	public float _Fspeed;
	public float _NoSpeed;
	public float _MaxSpeed;
	public float _delay;
	private float Cooldown; 
    private float Duration; 
	private PlayerData _player_data;
    public void Test()
    {
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
            y+=0.5f;
            ActivatedCooldown = true;
            ActivatedEffect=false;
            Debug.Log("Normal");
        }
    }
    void chooseEffectid()
    { // Metodo para lanzar un id aleatorio entre los 4 casos
        Selected = Random.Range(1,5);
    }
    private void ChooseEffect(){ // casos o cambios de estado del jugador

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

    void RedEffect()
    {
        _Fspeed=2;
        _NoSpeed=2;
        _MaxSpeed=2;
        _moveForce =2;
        _delay=1;
        CubeRD.color = Color.red;
        Debug.Log("Red Effect triggered");
     }

    void GreenEffect()
    {
        _Fspeed=6;
        _NoSpeed=6;
        _MaxSpeed=6;
        _moveForce =6;
        _delay=1;
        CubeRD.color = Color.green;
        Debug.Log("Green Effect triggered");
    }

    void YellowEffect()
    {
        _Fspeed= 4;
        _NoSpeed= 4;
        _MaxSpeed= 4;
        _moveForce = 4;
        _delay=2;
        CubeRD.color = Color.yellow;
        Debug.Log("Yellow Effect triggered");
    }

    void BlueEffect()
    {
        CubeRD.color = Color.blue;
        Debug.Log("Blue Effect triggered");

    }
    void DefaultMovement()
    { // Variables default del movimiento del jugador
        _Fspeed=4;
        _NoSpeed=4;
        _MaxSpeed=4;
        _moveForce =4;
        _delay=1;
        CubeRD.color = Color.white;     
    }


    public ModifierController(GameObject _Cube_,Material _CubeRD_)
    {
        this.Cube = _Cube_;
        this.CubeRD = _CubeRD_;
    	_moveForce = _player_data.moveForce;
        _NoSpeed = _player_data.NoSpeed;
        _Fspeed = _player_data.Fspeed;
        _MaxSpeed = _player_data.MaxSpeed;
        _delay =_player_data.delay;
    }
    
}
