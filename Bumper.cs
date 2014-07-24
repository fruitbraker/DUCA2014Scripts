using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {
	private bool isBack;
	void Start() {

	}
	void Update() {

	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerController>().PlaySound(3);
			if(Input.GetAxisRaw("Vertical") == 1) {
				other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(other.gameObject.transform.forward * -1 * 
			                                         other.gameObject.GetComponent<PlayerController>().movementSpeed * 2f);
				isBack = true;
			} else if(Input.GetAxisRaw("Vertical") == -1) {
				other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(other.gameObject.transform.forward * 
				                                     other.gameObject.GetComponent<PlayerController>().movementSpeed * 2f);
				isBack = false;
			} else if(isBack) {
				other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(other.gameObject.transform.forward * -1 *
				                                     other.gameObject.GetComponent<PlayerController>().movementSpeed * 2f);
				isBack = false;
			} else if(!isBack) {
				other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(other.gameObject.transform.forward *
				                                     other.gameObject.GetComponent<PlayerController>().movementSpeed * 2f);
				isBack = true;
			}

		}
	}
}
	