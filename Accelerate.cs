using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {
	public float accelerateScale = 1000.0f;

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(transform.right * 
			              other.gameObject.GetComponent<PlayerController>().movementSpeed * 2);
		}
	}
}
