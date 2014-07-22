using UnityEngine;
using System.Collections;

public class PlatformLeftRightDestroy : MonoBehaviour {
	public float platformSpeed;
	public bool isRight;
	private Vector3 initialPosition;
	
	// Use this for initialization
	void Start () {
		initialPosition = this.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if(Vector3.Distance (initialPosition, this.transform.position) > .01) {
			if(isRight)
				transform.Translate (Vector3.right * Time.deltaTime * platformSpeed);
			if(!isRight)
				transform.Translate (Vector3.left * Time.deltaTime * platformSpeed);
		}
	}

	void OnTriggerStay(Collider other) {
		//This will affect the X axis
		if(other.gameObject.tag == "Player") {
			if(isRight)
				transform.Translate (Vector3.right * Time.deltaTime * platformSpeed);
			if(!isRight)
				transform.Translate (Vector3.left * Time.deltaTime * platformSpeed);
		}
	}
}
