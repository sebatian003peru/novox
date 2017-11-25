using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : MonoBehaviour 
{
	public float _Speed;
    public int _numberRandom;
    public bool _rote;
    public float _termina;
    public int _timeStop;
	 void Start()
    {
        _Speed = 10f;
        _numberRandom = -1;
        _rote=false;
        _termina = 0f;
        _timeStop = 0;
    }
	void Update ()
	{
		CubeController cubeController = new CubeController(_Speed,_numberRandom,_termina,_timeStop,_rote);
		//cubeController.RandomRotation(_numberRandom,_timeStop,_termina,_rote);
		ThisRotation();
	}
	void RotationCubePositionInicial()
    {
        if(_rote==true)
        {
             transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime*1.5f);
             _Speed +=0.15f;
             _termina +=0.45f;
        }
    }
    void RotationCubeUp()
    {
        if(_rote==true)
        {
            transform.Rotate (Vector3.up,_Speed * Time.deltaTime);
            _Speed +=0.01f;
            _termina +=0.35f;
        }
    }
    void RotationCubeDown()
    {
        if(_rote==true)
        {
            transform.Rotate (Vector3.down,_Speed * Time.deltaTime);
            _Speed +=0.01f;
            _termina +=0.35f;
        }
    }
    void RotationCubeRight()
    {
        if(_rote==true)
        {
            transform.Rotate (Vector3.right,_Speed * Time.deltaTime);
            _Speed +=0.01f;
            _termina +=0.35f;
        }
    }
    void RotationCubeLeft()
    {
        if(_rote==true)
        {
            transform.Rotate (Vector3.left,_Speed * Time.deltaTime);
            _Speed +=0.01f;
            _termina +=0.35f;
        }
    }
	void ThisRotation ()
	{
		
		if(_numberRandom==-1)
        {
            _timeStop++;
        }

        if(_termina >=110f)
        {
            _rote=false;
            _numberRandom=-1;
            _termina=0;
        }

        if(_timeStop==30f)
        {
            _numberRandom = Random.Range(0,5);
            Debug.Log(_numberRandom);
            _timeStop = 0; 
        }
		
		switch(_numberRandom)
        {
            case 0:
            _rote=true;
            RotationCubePositionInicial();
            break;

            case 1:
            _rote=true;
            RotationCubeUp();
            break;

            case 2:
            _rote=true;
            RotationCubeDown();
            break;
            
            case 3:
            _rote=true;
            RotationCubeLeft();
            break;

            case 4:
            _rote=true;
            RotationCubeRight();
            break;
        }
	}
}
