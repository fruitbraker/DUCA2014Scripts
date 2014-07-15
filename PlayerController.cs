using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {
	public float movementSpeed = 20.0f;
	public float accelerateThreshold = 50.0f;

	public Vector3 accelVector;
	public float movementThreshold = 20.0f;
	public float forwardSpeed = 0.0f;
	public float leftRightSpeed = 0.0f;
	public float deccelerateScale = 2f;
	public float speedThreshold = 10.0f;
	public bool isAccelerate = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
			leftRightSpeed = Input.GetAxis ("Horizontal") * movementSpeed;

			Vector3 movement = new Vector3 (leftRightSpeed, 0, forwardSpeed) + accelVector;

			CharacterController cc = GetComponent<CharacterController> ();
			//rigidbody.velocity = movement;
			cc.SimpleMove (movement);

			if (movementSpeed > movementThreshold)
					movementSpeed -= Time.deltaTime * deccelerateScale;

			if (movementSpeed < movementThreshold)
					movementSpeed += Time.deltaTime * deccelerateScale;

			if (Math.Abs (movementSpeed - movementThreshold) < .025) {
					movementSpeed = movementThreshold;

			}
		}

	public void accelerate(Vector3 a) {
		CharacterController cc = GetComponent<CharacterController> ();
		cc.slopeLimit = 180;
		accelVector = a;
	}

	public void defaultSlope() {
		CharacterController cc = GetComponent<CharacterController> ();
		cc.slopeLimit = 45;
		//accelVector = Vector3(0, 0, 0);
	}
}