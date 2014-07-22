using UnityEngine;
using System.Collections;

public class PlatformUpDownDestroy : MonoBehaviour {
	public float platformSpeed;
	public bool isUp;
	private Vector3 initialPosition;

	// Use this for initialization
	void Start () {
		initialPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () { 
		if(Vector3.Distance (initialPosition, this.transform.position) > .01) {
			if (isUp)
				transform.Translate (Vector3.up * Time.deltaTime * platformSpeed);
			if (!isUp)
				transform.Translate (Vector3.down * Time.deltaTime * platformSpeed);
		}

	}

	void OnTriggerStay(Collider other) {		
		//This will affect the Y axis
		if(other.gameObject.tag == "Player") {
			if (isUp)
				transform.Translate (Vector3.up * Time.deltaTime * platformSpeed);
			if (!isUp)
				transform.Translate (Vector3.down * Time.deltaTime * platformSpeed);
		}
	}
}


//store initial position
//