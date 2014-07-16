using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {
	public float movementSpeed;
	public float movementThreshold;
	public float deccelerateScale = 5.0f;

	void Start() {
		movementThreshold = movementSpeed;
		//Physics.gravity = new Vector3(0,-100,0);
	}

	// Update is called once per frame
	void FixedUpdate () {
		float leftRight = Input.GetAxisRaw ("Horizontal");
		float forward = Input.GetAxisRaw ("Vertical");

		Vector3 movement = new Vector3 (leftRight, 0.0f, forward);

		rigidbody.AddForce (movement * movementSpeed * Time.deltaTime);

		if (movementSpeed < movementThreshold)
			movementSpeed += Time.deltaTime * deccelerateScale;
		
		if (Math.Abs (movementSpeed - movementThreshold) < .025) {
			movementSpeed = movementThreshold;
			
		}

	}

	public void defaultSlope() {
		CharacterController cc = GetComponent<CharacterController> ();
		cc.slopeLimit = 45;
	}
}