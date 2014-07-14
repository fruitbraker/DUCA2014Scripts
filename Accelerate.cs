using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {
	public float accelerateScale = 1000.0f;
	// Use this for initialization
	void Start () {
		print (transform.forward.ToString ());
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerController>().accelerate(transform.forward * accelerateScale);
		}
	}
}
