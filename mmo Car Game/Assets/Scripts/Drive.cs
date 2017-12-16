using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Drive : MonoBehaviour {

	float Speed = 10.0F;
	float rotationSpeed = 100.0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float translation = CrossPlatformInputManager.GetAxis("Vertical") * Speed;
		float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
	}
}
