using UnityEngine;
using System.Collections;

public class ChangeRespawn : MonoBehaviour {
	public GameObject newRespawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player")
			other.GetComponent<PlayerController> ().characterRespawn = newRespawn;
	}
}
