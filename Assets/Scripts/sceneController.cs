using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour {

	public void changeLevel(string s) {
		SceneManager.LoadScene (s);
	}

	public void exitGame() {
		Application.Quit ();
	}
}
