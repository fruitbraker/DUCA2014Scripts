using UnityEngine;
using System.Collections;

public class KeyandDoor : MonoBehaviour {
	public GameObject door;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collision other) {
		Destroy (door);
		Destroy (other.gameObject);
	}

}
