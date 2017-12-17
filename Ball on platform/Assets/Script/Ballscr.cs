using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscr : MonoBehaviour {

	public float moveSpeed;

	public KeyCode up;
	public KeyCode down;
	public KeyCode lrft;
	public KeyCode right;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement;
		if (Input.GetKey (up)){
			movement = new Vector3 (-moveSpeed, 0, 0);
		}
		else if (Input.GetKey (down)){
			movement = new Vector3 (moveSpeed, 0, 0);
		}
		else if (Input.GetKey (lrft)){
			movement = new Vector3 (0, 0, -moveSpeed);
		}
		else if (Input.GetKey (right)){
			movement = new Vector3 (0, 0, moveSpeed);
		}
		else movement = new Vector3 (0, 0, 0);
		// = Input.GetKey ("Horizental");
		//float VAsix = Input.GetKey ("Vertical");
		//movement = new Vector3 (-hAsix, 0, -VAsix);
		rb.velocity += movement;

	}
}
