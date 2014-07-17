﻿using UnityEngine;
using System.Collections;

public class Decelerate : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerStay(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerController>().movementSpeed = 2500f;
		}
	}
}
