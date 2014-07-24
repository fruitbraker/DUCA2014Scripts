using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
	public GameObject door;
	public GameObject key;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerController>().PlaySound(2);
			Destroy (door);
			Destroy (key);
		}
	}
}
