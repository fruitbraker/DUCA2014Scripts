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
		Destroy (door);
		Destroy (key);
	}
}
