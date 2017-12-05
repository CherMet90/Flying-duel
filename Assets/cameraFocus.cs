using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFocus : MonoBehaviour {

	public Transform focusedObj;

	void FixedUpdate () {
		transform.LookAt (focusedObj);
	}
}
