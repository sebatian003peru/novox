using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectTextManager : MonoBehaviour {

	public Text Efecttxt;
	public Light Light1;
	public Light Light2;
	public Light Light3;
	public Light Light4;
	public Light Light5;
	public Light Light6;
	public Light Light7;
	public Light Light8;
	public bool Fade;
	float alpha;

	private ModifiersView MV;

	void Start()
	{
		MV = GameObject.FindGameObjectWithTag ("Player").GetComponent <ModifiersView> ();
		alpha=0f;
		Efecttxt.color = new Color(0f,0f,0f,alpha);
		Light1.color = new Color(0f,0f,0f,alpha);
		Light2.color = new Color(0f,0f,0f,alpha);
		Light3.color = new Color(0f,0f,0f,alpha);
		Light4.color = new Color(0f,0f,0f,alpha);
		Light5.color = new Color(0f,0f,0f,alpha);
		Light6.color = new Color(0f,0f,0f,alpha);
		Light7.color = new Color(0f,0f,0f,alpha);
		Light8.color = new Color(0f,0f,0f,alpha);
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

		if (MV.modifierController.Selected==1)
		{
			Light1.color = Color.red;
			Light2.color = Color.red;
			Light3.color = Color.red;
			Light4.color = Color.red;
			Light5.color = Color.red;
			Light6.color = Color.red;
			Light7.color = Color.red;
			Light8.color = Color.red;
			Efecttxt.text="Extra Weight";
			Efecttxt.color = Color.red;
			Fade=true;
		}

		if (MV.modifierController.Selected==2)
		{
			Light1.color = Color.green;
			Light2.color = Color.green;
			Light3.color = Color.green;
			Light4.color = Color.green;
			Light5.color = Color.green;
			Light6.color = Color.green;
			Light7.color = Color.green;
			Light8.color = Color.green;
			Efecttxt.text="Extra Speed";
			Efecttxt.color = Color.green;
			Fade=true;
		}
		if (MV.modifierController.Selected==3)
		{
			Light1.color = Color.yellow;
			Light2.color = Color.yellow;
			Light3.color = Color.yellow;
			Light4.color = Color.yellow;
			Light5.color = Color.yellow;
			Light6.color = Color.yellow;
			Light7.color = Color.yellow;
			Light8.color = Color.yellow;
			Efecttxt.text="Delayed Controls";
			Efecttxt.color = Color.yellow;
			Fade=true;
		}

		if (MV.modifierController.Selected==4)
		{
			Light1.color = Color.blue;
			Light2.color = Color.blue;
			Light3.color = Color.blue;
			Light4.color = Color.blue;
			Light5.color = Color.blue;
			Light6.color = Color.blue;
			Light7.color = Color.blue;
			Light8.color = Color.blue;
			Efecttxt.text="Inverted Controls";
			Efecttxt.color = Color.blue;
			Fade=true;
		}

		if (MV.modifierController.ActivatedCooldown==true)
		{
			Light1.color = Color.white;
			Light2.color = Color.white;
			Light3.color = Color.white;
			Light4.color = Color.white;
			Light5.color = Color.white;
			Light6.color = Color.white;
			Light7.color = Color.white;
			Light8.color = Color.white;
			Efecttxt.text="Normal";
			Efecttxt.color = Color.white;
			Fade=true;
		}
	
	}

	public void FadeColor()
	{
		alpha-=Time.deltaTime;
	}
}
