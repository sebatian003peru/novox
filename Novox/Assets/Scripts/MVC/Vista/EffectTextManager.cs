using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectTextManager : MonoBehaviour {

	public Text Efecttxt;
	public bool Fade;
	float alpha;

	private ModifiersView MV;

	void Start()
	{
		MV = GameObject.FindGameObjectWithTag ("Player").GetComponent <ModifiersView> ();
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

		if (MV.modifierController.Selected==1)
		{
			Efecttxt.text="Extra Weight";
			Efecttxt.color = Color.red;
			Fade=true;
		}

		if (MV.modifierController.Selected==2)
		{
			Efecttxt.text="Extra Speed";
			Efecttxt.color = Color.green;
			Fade=true;
		}
		if (MV.modifierController.Selected==3)
		{
			Efecttxt.text="Delayed Controls";
			Efecttxt.color = Color.yellow;
			Fade=true;
		}

		if (MV.modifierController.Selected==4)
		{
			Efecttxt.text="Inverted Controls";
			Efecttxt.color = Color.blue;
			Fade=true;
		}

		if (MV.modifierController.ActivatedCooldown==true)
		{
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
