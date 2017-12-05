using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	float linearSpeed=0f;
	float rotationSpeed=40f;
	public float deltaSpeed = 10f;

	void Start() {
		Debug.Log ("The game was started now...");
	}

	void FixedUpdate() {
		transform.Translate (-Vector3.forward * linearSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Rotate (-Vector3.right * rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Rotate (-Vector3.left * rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.Z))
			transform.Rotate (Vector3.down * rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.X))
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (-Vector3.forward * rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (-Vector3.back * rotationSpeed * Time.deltaTime);
		if (Input.GetKeyUp (KeyCode.KeypadPlus))
			linearSpeed = linearSpeed + deltaSpeed;
		if (Input.GetKeyUp (KeyCode.KeypadMinus) && linearSpeed>0)
			linearSpeed = linearSpeed - deltaSpeed;
	}
}