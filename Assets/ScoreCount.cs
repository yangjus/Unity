using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour {

	public static ScoreCount instance = null;
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
	}

	public void Collect(int passedValue, GameObject passedObject) {
		Destroy (passedObject);
	}
}
