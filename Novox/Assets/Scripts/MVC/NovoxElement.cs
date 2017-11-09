using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovoxElement : MonoBehaviour {


   // Gives access to the application and all instances.
   public NovoxApplication app { get { return GameObject.FindObjectOfType<NovoxApplication>(); }}

public class NovoxApplication : NovoxElement
{
   // Reference to the root instances of the MVC.
   public NovoxModel model;
   public NovoxView view;
   public NovoxController controller;

   // Init things here
   void Start() { }
}
}
