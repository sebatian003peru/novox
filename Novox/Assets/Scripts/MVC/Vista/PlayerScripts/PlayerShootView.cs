using UnityEngine;
using System.Collections;

public class PlayerShootView : PlayerShootManager
{

    public float shotValue = 0.0f;
    public float barTopLimit = 200.0f;
    public float barHeight;
    public Texture texture;
    public GameObject ball;
    public Transform source;
    Material material;
    Color color; 
    float counter1 = 0.0f;
    bool up = true;
    bool down = false;
    public float snapValue = 0.0f;

    public float newShotPower = 12.5f;
    void Start()
    {
        
        color = new Color(1, 1, 1, 1);
    }

    void Update()
    {       
        CountPressPingPong();
        shotValue = (int)(ShotPower(barHeight));
        barHeight = CountPressPingPong() * barTopLimit;
    }

    void MakeShot(float power)
    {
        if (Input.GetMouseButtonUp(0))
        {
           // GameObject prefab = Instantiate(ball, source.position, Quaternion.identity) as GameObject;
            //prefab.GetComponent<Rigidbody>().AddForce(source.transform.TransformDirection(0, 0, 1 * power * 1.25f), ForceMode.Impulse);
            //Destroy(prefab, 5.0f);
        }
    }
    public float ShotPower(float inputValue)
    {
        if (Input.GetMouseButtonUp(0))
        {
            snapValue = inputValue;
            return snapValue;
        }
        return snapValue;
    }
    Color ChangeColor(Color color, float height)
    {
        Color color1 = new Color(0,1,0,1);
        Color color2 = new Color(1,0,0,1);

        color = Color.Lerp(color1, color2, height);
        return color;
    }
    float MapRange(float inputValue, float inputValueMin, float inputValueMax, float outputValueMin, float outputValueMax)
    {
        float outputValue = (inputValue - inputValueMin) / 
                            (inputValueMax - inputValueMin) * 
                            (outputValueMax - outputValueMin) + outputValueMin;
        return outputValue;
    }
    float CountPressPingPong()
    {
        if (Input.GetMouseButton(0))
        {
            if (up)
            {
                counter1 += Time.deltaTime/2;
                if (counter1 >= 1.0f)
                {
                    up = false;
                    down = true;
                    return counter1;
                }
                return counter1;
            }
            else if (down)
            {
                counter1 -= Time.deltaTime/2;
                if (counter1 <= 0.0f)
                {
                    up = true;
                    down = false;
                    return counter1;
                }
                return counter1;
            }
            return counter1;
        }
        else
        {
            counter1 = 0.0f;
            return counter1;
        }

    }

}
