using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour {

	public GameObject[] tutorials;
	public int currentTutorial;

	void Start(){
		currentTutorial=0;
	}


	void Update()
	
	{

		if (currentTutorial == 0){
		 tutorials[currentTutorial].SetActive(true);
		 }

	}



	public void Exit ()
	{
		SceneManager.LoadScene ("MainMenu");
	}
	public void Next ()
	{
		currentTutorial+=1;
		tutorials[currentTutorial].SetActive(true);
		tutorials[currentTutorial-1].SetActive(false);
	}

	public void Back ()
	{
		currentTutorial-=1;
		tutorials[currentTutorial].SetActive(true);
		tutorials[currentTutorial+1].SetActive(false);
	}



}
