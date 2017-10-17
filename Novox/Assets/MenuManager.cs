
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {


	public void LoadGame (string SceneName) {

		SceneManager.LoadScene(SceneName);
		
	}
}
