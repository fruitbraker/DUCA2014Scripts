using UnityEngine;
using System.Collections;

public class FallInstantly : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider other) {
		if(other.gameObject.tag == "Player") {
			print ("HCEE");
			other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(transform.up * 
			                           other.gameObject.GetComponent<PlayerController>().movementSpeed * -2);
		}
	}
}
