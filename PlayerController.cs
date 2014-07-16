using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {
	public float movementSpeed;
	// Update is called once per frame
	void FixedUpdate () {
		float leftRight = Input.GetAxisRaw ("Horizontal");
		float forward = Input.GetAxisRaw ("Vertical");

		Vector3 movement = new Vector3 (leftRight, 0.0f, forward);

		rigidbody.AddForce (movement * movementSpeed * Time.deltaTime);

	}

	public void defaultSlope() {
		CharacterController cc = GetComponent<CharacterController> ();
		cc.slopeLimit = 45;
	}
}