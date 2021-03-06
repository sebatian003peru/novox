﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class PlayerShootController : PlayerShootManager,IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [HideInInspector]
    public Vector3 currentPosition;
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 defaulPos;
    public Transform midPoint_out;
    PlayerShootData SS;
    GameObject pl;

    //BallRotation

    Quaternion rotation;
    Vector3 initRot;
    float rotSpeed = 5;
    float rotationZ;
    float sensitivityZ = 2;

     public void OnBeginDrag(PointerEventData eventData)
    {
              offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                                                                             Input.mousePosition.y, screenPoint.z));
        Cursor.visible = false;
        //Debug.Log(offset);
    }

    public void OnDrag(PointerEventData eventData)
    {
         Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;

        transform.position = currentPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Cursor.visible = true;
        SS.MakeShot(SS.startPower);
    }

    void Start()
    {
        SS = GameObject.Find("slingshot").GetComponent<PlayerShootData>();
        defaulPos = new Vector3(-6.25f, -0.25f, 0);
        transform.position = defaulPos;
        transform.rotation = Quaternion.identity;
    }
    void Update()
    {
        LockedRotation();
    }
      
   
   void OnMouseDown()
   {
       offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                                                                            Input.mousePosition.y, screenPoint.z));
       Cursor.visible = false;
       //Debug.Log(offset);
   }
   void OnMouseDrag()
   {
       Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
       currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;
       transform.position = currentPosition;
       
   }
   void OnMouseUp()
   {
       Cursor.visible = true;
       SS.MakeShot(SS.startPower);       
   }

      void LockedRotation()
    {
        rotationZ += Input.GetAxis("Mouse ScrollWheel") * sensitivityZ * 10;
        rotationZ = Mathf.Clamp(rotationZ, -30.0f, 30.0f);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);
    }
}

