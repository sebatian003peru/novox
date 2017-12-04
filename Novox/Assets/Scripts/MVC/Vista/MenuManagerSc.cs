using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerSc : MonoBehaviour 
{
	public void Play ()
	{
		SceneManager.LoadScene ("Build");
	}
	public void Credit ()
	{
		SceneManager.LoadScene ("Creditos");
	}
	public void Exit ()
	{
		Application.Quit();
	}
	public void Exit1 ()
	{
		SceneManager.LoadScene ("MainMenu");
	}
	public void Game2 ()
	{
		SceneManager.LoadScene ("scene1");
	}
	public void Tutorial ()
	{
		SceneManager.LoadScene ("Tutorial");
	} 
}
