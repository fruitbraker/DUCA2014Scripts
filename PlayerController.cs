﻿using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {
	public static bool isDead;
	public float movementSpeed;
	public float turnSpeed;
	public float movementThreshold;
	public float deccelerateScale;
	public float respawnThreshold;
	public string nextLevel;
	public AudioClip[] audioClip;
	public GameObject characterRespawn;
	private float leftRight;
	private float forward;

	void Start() {
		movementThreshold = movementSpeed;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.P)) 
			Application.LoadLevel(nextLevel);

		if(SystemInfo.deviceType == DeviceType.Handheld) {
			leftRight = Mathf.Clamp(Input.acceleration.x *3f, -1, 1);
			forward = Mathf.Clamp(Input.acceleration.y *3f, -1, 1);
		} else {
			leftRight = Input.GetAxisRaw ("Horizontal") * turnSpeed;
			forward = Input.GetAxisRaw ("Vertical");
		}

		Vector3 movement = transform.forward * forward;

		transform.Rotate(Vector3.up * leftRight);

		if(transform.position.y < respawnThreshold) {
			PlaySound(5);
			MasterResetter.shouldReset = true;
			isDead = true;
			movement = Vector3.zero;
			rigidbody.velocity = Vector3.zero;
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

	public void PlaySound(int index) {
		audio.clip = audioClip [index];
		audio.Play();
	}
}