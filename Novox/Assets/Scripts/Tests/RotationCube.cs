using UnityEngine;

public class RotationCube : MonoBehaviour {

    public float Speed;
    public int numberRandom;
    public bool rote;
    public float termina;
    public int timeStop;

    void Start()
    {
        Speed = 35f;
        numberRandom = -1;
        rote=false;
        termina = 0f;
        timeStop = 0;
    }
	void Update ()
    {

        if(numberRandom==-1)
        {
            timeStop++;
        }

        if(termina >=110f)
        {
            rote=false;
            numberRandom=-1;
            termina=0;
        }

        if(timeStop==30f)
        {
            numberRandom = Random.Range(0,5);
            Debug.Log(numberRandom);
            timeStop = 0; 
        }
        switch(numberRandom)
        {
            case 0:
            rote=true;
            RotationCubePositionInicial();
            break;

            case 1:
            rote=true;
            RotationCubeUp();
            break;

            case 2:
            rote=true;
            RotationCubeDown();
            break;
            
            case 3:
            rote=true;
            RotationCubeLeft();
            break;

            case 4:
            rote=true;
            RotationCubeRight();
            break;
        }
    }
    void RotationCubePositionInicial()
    {
        if(rote==true)
        {
             transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime*1.5f);
             Speed +=0.15f;
             termina +=0.45f;
        }
    }
    void RotationCubeUp()
    {
        if(rote==true)
        {
            transform.Rotate (Vector3.up,Speed * Time.deltaTime);
            Speed +=0.01f;
            termina +=0.35f;
        }
    }
    void RotationCubeDown()
    {
        if(rote==true)
        {
            transform.Rotate (Vector3.down,Speed * Time.deltaTime);
            Speed +=0.01f;
            termina +=0.35f;
        }
    }
    void RotationCubeRight()
    {
        if(rote==true)
        {
            transform.Rotate (Vector3.right,Speed * Time.deltaTime);
            Speed +=0.01f;
            termina +=0.35f;
        }
    }
    void RotationCubeLeft()
    {
        if(rote==true)
        {
            transform.Rotate (Vector3.left,Speed * Time.deltaTime);
            Speed +=0.01f;
            termina +=0.35f;
        }
    }
}