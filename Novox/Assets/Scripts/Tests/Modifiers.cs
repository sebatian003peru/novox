using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifiers : DifficultyControl {


public bool ActivatedCooldown;
public bool ActivatedEffect; 

public void Start (){

    ActivatedCooldown=true;
    ActivatedEffect = false;
}


public void SwipeDetector(float Fspeed, float NoSpeed, float MaxSpeed, float moveForce, float delay) { // Constructor para poder modificar las variables en los casos del switch

        this.Fspeed = Fspeed;
        this.NoSpeed = NoSpeed;
        this.MaxSpeed= MaxSpeed;
        this.moveForce= moveForce;
        this.delay = delay;
}

 void chooseEffectid(){ // Metodo para lanzar un id aleatorio entre los 4 casos

ID = Random.Range(1,4);

 }

 void DefaultMovement(){ // Variables default del movimiento del jugador
     Fspeed=3f;
     moveForce=1.5f;
 }

 private void ChooseEffect(){ // casos o cambios de estado del jugador

     switch(ID){

         case 1: //Rojo: La pelota es mas pesada

         Fspeed=4;
         NoSpeed=4;
         MaxSpeed=4;
         moveForce =4;
         delay=1;

         break;

         case 2://Verde: La pelota el mas ligera

         Fspeed=4;
         NoSpeed=4;
         MaxSpeed=4;
         moveForce =4;
         delay=1;

         break;

         case 3: //Amarillo: el delay entre swipes aumenta

         Fspeed=4;
         NoSpeed=4;
         MaxSpeed=4;
         moveForce =4;
         delay=1;

         break;

         case 4: //Azul: Los controles se invierten (LAS VARIABLES PAFRA ELLO FALTAS)

         Fspeed=4;
         NoSpeed=4;
         MaxSpeed=4;
         moveForce =4;
         delay=1;

         break;

         //(FALTA LA LLAMAR A LA VARIABLE DE COLOR DEL CUBO Y REALIZAR EL CAMBIO RESPECTIVO SEGUN EL CASO)
     }
 }

 void Update(){

if (ActivatedCooldown){ // Cooldown es el periodo que representa el intermedio entre dos cambios. Es decir que cuando este acabe ocurrira un cambio

Cooldown=- Time.deltaTime;
DefaultMovement();
}
 
 else if (!ActivatedCooldown)
 {
  Cooldown =  0;  
 }


if (Cooldown == 0){  // Al acabar el cooldown se llama al metodo para elegir un id aleatorio y se inicia el contador que determina la duracion del cambio

         chooseEffectid();
         ActivatedCooldown = false;
         ActivatedEffect = true;
 }

if (ActivatedEffect){

    Duration=- Time.deltaTime;
    ChooseEffect();
}

else if (!ActivatedEffect){ 
    Duration = 0;
    
}

if (Duration==0){
    ActivatedEffect=false;
    ActivatedCooldown = true;
    DefaultMovement();

}
 
 }


 


}
