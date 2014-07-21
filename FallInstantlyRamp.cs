using UnityEngine;
using System.Collections;

public class FallInstantlyRamp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "Player")
			Physics.gravity = new Vector3(0,-100f,0);
	}
}
