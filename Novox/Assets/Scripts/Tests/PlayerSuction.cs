using UnityEngine;
using System.Collections;

public class PlayerSuction : MonoBehaviour
{

    GameObject attractedTo;
    public bool inside;
    Rigidbody PlayerRb;
    public float strengthOfAttraction;
     
         void Start ()
         {
             attractedTo = GameObject.FindGameObjectWithTag("Player");
             PlayerRb= attractedTo.GetComponent<Rigidbody>();
         }

         void Update() 
         {
         
         if (inside == true) 
         {
         Vector3 direction = transform.position - attractedTo.transform.position;
                 PlayerRb.AddForce (strengthOfAttraction * direction);
        }
        }
     
         void OnTriggerEnter (Collider col)
         {
                 
                 if (col.gameObject.tag =="Player") {  
                     inside =true;

                 }
               
         }

         void OnTriggerExit (Collider col){

              if (col.gameObject.tag =="Player") 
              {  
                     inside =false;

                 }
         }
}
  