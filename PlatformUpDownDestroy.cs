using UnityEngine;
using System.Collections;

public class PlatformUpDownDestroy : MonoBehaviour {
	public float platformSpeed;
	public bool isUp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay(Collider other) {		
		//This will affect the Y axis
		if(other.gameObject.tag == "Player") {
			if(isUp)
				transform.Translate (Vector3.up * Time.deltaTime * platformSpeed);
			if (!isUp)
				transform.Translate (Vector3.down * Time.deltaTime * platformSpeed);
		}
	}
}
