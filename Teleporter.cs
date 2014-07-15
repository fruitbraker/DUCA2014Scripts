using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {
	public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			Vector3 targetPosition = (target.transform.position);
			print (target.transform.position.y);
			targetPosition.y += 5.3f;
			other.gameObject.transform.position = targetPosition;
		}
	}
}
