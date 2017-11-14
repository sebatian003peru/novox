using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifierController : ModifiersData {

	private float Cooldown; 
    private float Duration; 
	private PlayerData _player_data;

	void Update()
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

public ModifierController(float moveForce, float Fspeed, float NoSpeed, float MaxSpeed, float delay){

	    moveForce = _player_data.moveForce;
        NoSpeed = _player_data.NoSpeed;
        Fspeed = _player_data.Fspeed;
        MaxSpeed = _player_data.MaxSpeed;
        delay =_player_data.delay;
	
}

}
