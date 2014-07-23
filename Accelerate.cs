using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {
	public bool isLevel5;
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			if(isLevel5){
				other.gameObject.GetComponent<PlayerController>().rigidbody.velocity = Vector3.zero;
				other.gameObject.transform.position = transform.position;
			}
			other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(transform.right *
			                other.gameObject.GetComponent<PlayerController>().movementSpeed * .4f);
		}
	}
}
