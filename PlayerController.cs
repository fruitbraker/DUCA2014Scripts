﻿using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {
	public float movementSpeed;
	public float turnSpeed;
	public float movementThreshold;
	public float deccelerateScale;
	public float respawnThreshold;
	public GameObject characterRespawn;
	void Start() {
		movementThreshold = movementSpeed;
	}

	// Update is called once per frame
	void FixedUpdate () {
		float leftRight = Input.GetAxisRaw ("Horizontal") * turnSpeed;
		float forward = Input.GetAxisRaw ("Vertical");

		Vector3 movement = transform.forward * forward;

		transform.Rotate(Vector3.up * leftRight);

		if(transform.position.y < respawnThreshold) {
			movement = Vector3.zero;
			transform.position = characterRespawn.transform.position;
		}

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