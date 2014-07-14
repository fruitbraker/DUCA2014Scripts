using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {
	public float accelerateScale = 10.0f;
	public PlayerController pc;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other) {
		if (other.gameObject.tag == "Player") {
			pc = other.gameObject.GetComponent<PlayerController>();
			pc.movementSpeed = pc.accelerateThreshold;
		}
	}
}
