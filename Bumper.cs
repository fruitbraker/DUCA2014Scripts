using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	void Start() {

	}
	void Update() {

	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			if(Input.GetAxisRaw("Vertical") == 1) {
				other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(other.gameObject.transform.forward * -1 * 
			                                         other.gameObject.GetComponent<PlayerController>().movementSpeed * 2f);
			}

			if(Input.GetAxisRaw("Vertical") == -1) {
				other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(other.gameObject.transform.forward * 
				                                     other.gameObject.GetComponent<PlayerController>().movementSpeed * 2f);
			}
		}
	}
}
	