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
			//other.gameObject.GetComponent<PlayerController>().rigidbody.AddForce(transform.up * 
			//                           other.gameObject.GetComponent<PlayerController>().movementSpeed * -.25f);
			Physics.gravity = new Vector3(0,-100f,0);
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "Player")
			Physics.gravity = new Vector3(0, -9.8f, 0);
	}
}
