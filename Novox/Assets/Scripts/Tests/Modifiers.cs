 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifiers : PlayerMove {

public GameObject Cube;
Material CubeRD;
int Selected;
public float Cooldown; 
public float Duration;  
public float DifficultTimer;
public float x = 3;
public float y = 3;
public bool ActivatedCooldown;
public bool ActivatedEffect; 

public void Start (){
    
    ActivatedCooldown=true;
    ActivatedEffect = false;
    Cube= GameObject.FindGameObjectWithTag("Cube");
    CubeRD= Cube.GetComponent<Renderer>().material;
}


public void PlayerMove(float Fspeed, float NoSpeed, float MaxSpeed, float moveForce, float delay) { // Constructor para poder modificar las variables en los casos del switch

        this.Fspeed = Fspeed;
        this.NoSpeed = NoSpeed;
        this.MaxSpeed= MaxSpeed;
        this.moveForce= moveForce;
        this.delay = delay;
}

 void DefaultMovement(){ // Variables default del movimiento del jugador
        Fspeed=4;
         NoSpeed=4;
         MaxSpeed=4;
         moveForce =4;
         delay=1;
         CubeRD.color = Color.white;
         
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

         //(FALTA LA LLAMAR A LA VARIABLE DE COLOR DEL CUBO Y REALIZAR EL CAMBIO RESPECTIVO SEGUN EL CASO)
     }
 }

 void RedEffect(){
     
        Fspeed=2;
         NoSpeed=2;
         MaxSpeed=2;
         moveForce =2;
         delay=1;
         CubeRD.color = Color.red;
         Debug.Log("Red Effect triggered");
 }

 void GreenEffect(){

        Fspeed=6;
         NoSpeed=6;
         MaxSpeed=6;
         moveForce =6;
         delay=1;
         CubeRD.color = Color.green;
         Debug.Log("Green Effect triggered");

 }

 void BlueEffect(){

 }

 void YellowEffect(){

        Fspeed=4;
         NoSpeed=4;
         MaxSpeed=4;
         moveForce =4;
         delay=2;
         CubeRD.color = Color.yellow;
         Debug.Log("Yellow Effect triggered");

 }

 void Update(){

if (ActivatedCooldown){ // Cooldown es el periodo que representa el intermedio entre dos cambios. Es decir que cuando este acabe ocurrira un cambio

Cooldown-= Time.deltaTime;

}
 
 else if (!ActivatedCooldown)
 {
  Cooldown =  x;  
 }


if (Cooldown <= 0){  // Al acabar el cooldown se llama al metodo para elegir un id aleatorio y se inicia el contador que determina la duracion del cambio

         chooseEffectid();
         ActivatedCooldown = false;
         ActivatedEffect = true;
 }

if (ActivatedEffect){

    Duration-= Time.deltaTime;
    ChooseEffect();
}

else if (!ActivatedEffect){ 
    Duration = y;
    
}

if (Duration<=0){
    ActivatedEffect=false;
    ActivatedCooldown = true;
    DefaultMovement();
    Debug.Log("Normal");

}

DifficultTimer += Time.deltaTime;

if (DifficultTimer >= 20) {

 x-= 0.5f;
 y+=0.5f;
 Reset();

 }

}

void Reset(){

    DifficultTimer = 0;

 }

  void chooseEffectid(){ // Metodo para lanzar un id aleatorio entre los 4 casos

 Selected = Random.Range(1,5);

 }

}


 



