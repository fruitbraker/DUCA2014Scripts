using UnityEngine;
using System.Collections;

public class PlatformForwardBackDestroy : MonoBehaviour {
	public float platformSpeed;
	public bool isForward;
	private Vector3 initialPosition;
	
	// Use this for initialization
	void Start () {
		initialPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance (initialPosition, this.transform.position) > .01) {
			if(isForward)
				transform.Translate (Vector3.forward * Time.deltaTime * platformSpeed);
			if(!isForward)
				transform.Translate (Vector3.back * Time.deltaTime * platformSpeed);
		}
	}

	void OnTriggerStay(Collider other) {
		//This will affect the Z axis
		if(other.gameObject.tag == "Player") {
			if(isForward)
				transform.Translate (Vector3.forward * Time.deltaTime * platformSpeed);
			if(!isForward)
				transform.Translate (Vector3.back * Time.deltaTime * platformSpeed);
		}
	}
}
