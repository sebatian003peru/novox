using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectTextManager : MonoBehaviour {

	public Text Efecttxt;
	ModifierController MC;
	public bool Fade;
	float alpha;

	void Start()
	{
		alpha=0f;
		Efecttxt.color = new Color(0f,0f,0f,alpha);
		Fade=false;

	}
	void Update () 
	{
		if (Fade==true)
		{
			FadeColor();
		}

		if(alpha<=0)
		{
			alpha=0f;
			Fade=false;
		}

		if (MC.Selected==1)
		{
			Efecttxt.text="Red Effect Activated"+"Extra Weight";
			Efecttxt.color = Color.red;
			Fade=true;
		}

		if (MC.Selected==2)
		{
			Efecttxt.text="Green Effect Activated"+"Extra Speed";
			Efecttxt.color = Color.green;
			Fade=true;
		}
		if (MC.Selected==3)
		{
			Efecttxt.text="Yellow Effect Activated"+"Delayed Controls";
			Efecttxt.color = Color.yellow;
			Fade=true;
		}

		if (MC.Selected==4)
		{
			Efecttxt.text="Blue Effect Activated"+"Inverted Controls";
			Efecttxt.color = Color.blue;
			Fade=true;
		}

		if (MC.Selected==5)
		{
			Efecttxt.text="Blue Effect Activated"+"Inverted Controls";
			Efecttxt.color = Color.black;
			Fade=true;
		}
	
	}

	public void FadeColor()
	{
		alpha-=Time.deltaTime;
	}
}
