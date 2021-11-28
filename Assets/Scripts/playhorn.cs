using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playhorn : MonoBehaviour {
	AudioSource audio1;
	// Use this for initialization
	void Start () {
		audio1 = GetComponent<AudioSource> ();
	}
	
	public void beep() {
		audio1.Play ();
	}
}
