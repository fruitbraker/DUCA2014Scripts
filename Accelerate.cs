using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(other.gameObject.transform.up * -1 *
			              other.gameObject.GetComponent<PlayerController>().movementSpeed * 2000);
		}
	}
}
