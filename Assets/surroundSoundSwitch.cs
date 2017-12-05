using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surroundSoundSwitch : MonoBehaviour {

	AudioListener surroundSoundSwitcher;

	void Awake () {
		surroundSoundSwitcher = Camera.main.GetComponent<AudioListener>();
	}

	void Start () {
		Debug.Log ("Scene started...");
	}

	void Update () {
		if (Input.GetKeyUp (KeyCode.LeftShift))
			surroundSoundSwitcher.enabled=!surroundSoundSwitcher.enabled;
	}

}
