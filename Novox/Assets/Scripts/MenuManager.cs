﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

 public void LoadScene(string SceneName){
	SceneManager.LoadScene(SceneName);
 }
}